using System;
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
    public partial class CheckForm : Form
    {
        decimal TotalCost;
        public decimal RestMoney;
        public bool Ready2Save;

        public CheckForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSum2Payment_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            decimal payment = 0;

            if (!decimal.TryParse(tbxSumToPayment.Text, out payment))
            {
                MessageBox.Show("Не верный формат суммы");
                tbxSumToPayment.Text = "";
                tbxSumToPayment.Focus();
            }

            if(payment < TotalCost)
            {
                MessageBox.Show("Сумма недостаточна для оплаты");
                tbxSumToPayment.Text = "";
                tbxSumToPayment.Focus();
            }

            RestMoney = payment - TotalCost;
            Ready2Save = true;

            this.Close();
        }


        public void ShowChek(decimal totalCost)
        {
            TotalCost = totalCost;
            lblSum2Payment.Text = TotalCost.ToString();
            ShowDialog();
        } 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
