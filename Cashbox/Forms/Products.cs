using Cashbox.Models;
using Cashbox.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashbox.Forms
{
    public partial class Products : Form
    {
        decimal totalSum = 0;
        int selectedProductId = 0;
        List<StoredProduct> StoredProducts = new List<StoredProduct>();
        DataContext Context;
        public Products(DataContext context)
        {

            Context = context;
            InitializeComponent();
            gridProducts.AutoGenerateColumns = false;
            gridProducts.DataSource = basketProductBindingSource;
            fillStoredProductsList();

            MessageBox.Show(@"
Демонстрационное приложение ""Рабочее место кассира"".

Для добавления товара в таблицу воспользуйтесь выпадающим списком в нижней части формы или нажмите клавишу ""Ins"" кликнув предварительно мышью на таблице. 
Для увеличения или уменьшения количества товара воспользуйтесь клавишами ""Влево"" и ""Вправо"" при выделенной строке товара или дважды щёлкните на ячейку столбца ""Количество"" и введите требуемую цифру. 
Для удаления товара из таблицы воспользуйтесь клавишей ""Delete"" при выделенной строек товара. 

Кнопка ""отмена"" очистит таблицу.
Кнопка ""рассчитать по чеку"" откроет форму оплаты.
");

        }

        void calcTotal()
        {
            lblStoredProductsCountValue.Text = gridProducts.RowCount.ToString();
            decimal sum = 0;
            foreach (var row in gridProducts.Rows)
                sum += (decimal)((DataGridViewRow)row).Cells["colSum"].Value;
            lblTotalSumValue.Text = sum.ToString();
        }

        Check createCheck()
        {
            var checkProducts = new List<CheckProduct>();
            foreach(DataGridViewRow row in gridProducts.Rows)
            {
                var it = (BasketProduct)row.DataBoundItem;
                checkProducts.Add(new CheckProduct()
                {
                    Count = it.Count,
                    Product = it.Product
                });

            }




            return new Check() {
                DateCreate = DateTime.Now
                , CheckProducts = new HashSet<CheckProduct>(checkProducts)
            };
        }

        bool saveCheck(Check check)
        {
            Context.Checks.Add(check);
            return Context.SaveChanges() > 0;
        }

        void calcCheck()
        {
            if (gridProducts.RowCount == 0) return;
            var check = createCheck();

            var frm = new CheckForm();
            frm.ShowChek(check.TotalCost);

            if (frm.Ready2Save)
            {
                if (saveCheck(check))
                {
                    MessageBox.Show("Данные сохранены. Сумма сдачи: " + frm.RestMoney.ToString());
                    clearBasket();
                }

            }
        }

        void calcBasketRow()
        {
            var productBasketItem = getSelectedBasketItem();
            if (productBasketItem == null)
            {
                selectedProductId = 0;
                lblCodeValue.Text = "_";
                lblCountValue.Text = "_";
                lblPriceValue.Text = "_";
                lblProductName.Text = "_";
                lblSumValue.Text = "000.00";
                totalSum = 0;
            }
            else
            {
                selectedProductId = productBasketItem.Id;
                lblCodeValue.Text = productBasketItem.Code;
                lblCountValue.Text = productBasketItem.Count.ToString();
                lblPriceValue.Text = productBasketItem.Price.ToString();
                lblProductName.Text = productBasketItem.Name;
                lblSumValue.Text = productBasketItem.Sum.ToString();
                totalSum = productBasketItem.Sum;
            }
            calcTotal();
        }

        BasketProduct getSelectedBasketItem()
        {
            var row = getSelectedRow();
            if (row == null) return null;
            return (BasketProduct)row.DataBoundItem;
        }

        DataGridViewRow getSelectedRow()
        {
            if (gridProducts.SelectedRows.Count == 0) return null;
            return gridProducts.SelectedRows[0];
        }

        void increaseCount()
        {
            var row = getSelectedRow();
            var count = (int)row.Cells["colCount"].Value;
            if (row == null || count > ((BasketProduct)row.DataBoundItem).Rests - 1) return;

            row.Cells["colCount"].Value = count + 1;
        }

        void reduceCount()
        {
            var row = getSelectedRow();
            var count = (int)row.Cells["colCount"].Value;
            if (row == null || count< 1) return;

            row.Cells["colCount"].Value = count - 1;
        }

        void deleteBasketItem()
        {
            var item = getSelectedBasketItem();
            if (item == null) return;
            var confirmResult = MessageBox.Show("Убрать из корзины продукт " + item.Name + "?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;
            basketProductBindingSource.Remove(item);
            gridProducts.Rows[0].Selected = true;
        }

        void clearBasket()
        {
            basketProductBindingSource.Clear();
            calcBasketRow();
        }

        void addBasketItem()
        {
            listStoredProducts.Focus();
        }

        void addProduct2Basket(StoredProduct storedProduct)
        {
            BasketProduct basketProduct = new BasketProduct(storedProduct);
            basketProductBindingSource.Add(basketProduct);
            gridProducts.Focus();
        }
        

        void fillStoredProductsList()
        {
            StoredProducts = Context.StoreProducts.Where(it => it.Count > 0).ToList().OrderBy(it => it.Name).ToList();
            storedProductBindingSource.DataSource = StoredProducts;
            listStoredProducts.DisplayMember = "Name";
            listStoredProducts.ValueMember = "Id";

            listStoredProducts.AutoCompleteSource = AutoCompleteSource.ListItems;
            listStoredProducts.AutoCompleteMode = AutoCompleteMode.Suggest;
            listStoredProducts.SelectedIndex = -1;

        }

        private void listStoredProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!(listStoredProducts.SelectedValue is int)) return;

            var id = (int)listStoredProducts.SelectedValue;
            var obj = StoredProducts.FirstOrDefault(it => it.Id == id);
            if (id != selectedProductId && obj != null)
            {
                addProduct2Basket(obj);
            }
            listStoredProducts.SelectedIndex = -1;
        }

        private void basketProductBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            calcBasketRow();
        }

        private void basketProductBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
             calcBasketRow();
        }


        private void gridProducts_KeyDown(object sender, KeyEventArgs e)
        {

            System.Diagnostics.Debug.WriteLine(e.KeyData.ToString());

            switch (e.KeyData)
            {
                case Keys.Left:
                    reduceCount();
                    break;
                case Keys.Right:
                    increaseCount();
                    break;
                case Keys.Delete:
                    deleteBasketItem();
                    break;
                case Keys.Insert:
                    addBasketItem();
                    break;
            }
        }

        private void listStoredProducts_Enter(object sender, EventArgs e)
        {
            listStoredProducts.DroppedDown = true;
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Убрать из корзины все продукты?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;
            clearBasket();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calcCheck();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
