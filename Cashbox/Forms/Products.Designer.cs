namespace Cashbox.Forms
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.basketProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.listStoredProducts = new System.Windows.Forms.ComboBox();
            this.storedProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblStoredProductsCountValue = new System.Windows.Forms.Label();
            this.lblStoredProductsCountName = new System.Windows.Forms.Label();
            this.lblTotalSumValue = new System.Windows.Forms.Label();
            this.lblTotalSumName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSumValue = new System.Windows.Forms.Label();
            this.lblSumName = new System.Windows.Forms.Label();
            this.lblCountValue = new System.Windows.Forms.Label();
            this.lblCountName = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPriceName = new System.Windows.Forms.Label();
            this.lblCodeValue = new System.Windows.Forms.Label();
            this.lblCodeName = new System.Windows.Forms.Label();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketProductBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storedProductBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тестовый интерфейс продавца";
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AllowUserToResizeColumns = false;
            this.gridProducts.AllowUserToResizeRows = false;
            this.gridProducts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCount,
            this.colSum});
            this.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProducts.Location = new System.Drawing.Point(0, 39);
            this.gridProducts.Margin = new System.Windows.Forms.Padding(4);
            this.gridProducts.MultiSelect = false;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(985, 578);
            this.gridProducts.TabIndex = 1;
            this.gridProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridProducts_KeyDown);
            // 
            // basketProductBindingSource
            // 
            this.basketProductBindingSource.DataSource = typeof(Cashbox.Models.ViewModels.BasketProduct);
            this.basketProductBindingSource.CurrentItemChanged += new System.EventHandler(this.basketProductBindingSource_CurrentItemChanged);
            this.basketProductBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.basketProductBindingSource_ListChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listStoredProducts);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnCalculate);
            this.panel2.Controls.Add(this.lblStoredProductsCountValue);
            this.panel2.Controls.Add(this.lblStoredProductsCountName);
            this.panel2.Controls.Add(this.lblTotalSumValue);
            this.panel2.Controls.Add(this.lblTotalSumName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 218);
            this.panel2.TabIndex = 2;
            // 
            // listStoredProducts
            // 
            this.listStoredProducts.DataSource = this.storedProductBindingSource;
            this.listStoredProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.listStoredProducts.FormattingEnabled = true;
            this.listStoredProducts.Location = new System.Drawing.Point(0, 103);
            this.listStoredProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listStoredProducts.Name = "listStoredProducts";
            this.listStoredProducts.Size = new System.Drawing.Size(985, 24);
            this.listStoredProducts.TabIndex = 10;
            this.listStoredProducts.SelectionChangeCommitted += new System.EventHandler(this.listStoredProducts_SelectionChangeCommitted);
            this.listStoredProducts.Enter += new System.EventHandler(this.listStoredProducts_Enter);
            // 
            // storedProductBindingSource
            // 
            this.storedProductBindingSource.DataSource = typeof(Cashbox.Models.StoredProduct);
            this.storedProductBindingSource.Filter = "";
            this.storedProductBindingSource.Sort = "";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(303, 134);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Green;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Location = new System.Drawing.Point(864, 131);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 84);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "рассчитать\r\nпо чеку";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblStoredProductsCountValue
            // 
            this.lblStoredProductsCountValue.AutoSize = true;
            this.lblStoredProductsCountValue.Location = new System.Drawing.Point(171, 183);
            this.lblStoredProductsCountValue.Name = "lblStoredProductsCountValue";
            this.lblStoredProductsCountValue.Size = new System.Drawing.Size(15, 16);
            this.lblStoredProductsCountValue.TabIndex = 7;
            this.lblStoredProductsCountValue.Text = "_";
            // 
            // lblStoredProductsCountName
            // 
            this.lblStoredProductsCountName.AutoSize = true;
            this.lblStoredProductsCountName.Location = new System.Drawing.Point(11, 183);
            this.lblStoredProductsCountName.Name = "lblStoredProductsCountName";
            this.lblStoredProductsCountName.Size = new System.Drawing.Size(151, 16);
            this.lblStoredProductsCountName.TabIndex = 7;
            this.lblStoredProductsCountName.Text = "Количество позиций :";
            // 
            // lblTotalSumValue
            // 
            this.lblTotalSumValue.AutoSize = true;
            this.lblTotalSumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalSumValue.Location = new System.Drawing.Point(719, 163);
            this.lblTotalSumValue.Name = "lblTotalSumValue";
            this.lblTotalSumValue.Size = new System.Drawing.Size(139, 42);
            this.lblTotalSumValue.TabIndex = 7;
            this.lblTotalSumValue.Text = "000.00";
            this.lblTotalSumValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalSumName
            // 
            this.lblTotalSumName.AutoSize = true;
            this.lblTotalSumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalSumName.Location = new System.Drawing.Point(676, 134);
            this.lblTotalSumName.Name = "lblTotalSumName";
            this.lblTotalSumName.Size = new System.Drawing.Size(182, 29);
            this.lblTotalSumName.TabIndex = 7;
            this.lblTotalSumName.Text = "итого сумма :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "формирование счёта";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblProductName);
            this.panel3.Controls.Add(this.lblSumValue);
            this.panel3.Controls.Add(this.lblSumName);
            this.panel3.Controls.Add(this.lblCountValue);
            this.panel3.Controls.Add(this.lblCountName);
            this.panel3.Controls.Add(this.lblPriceValue);
            this.panel3.Controls.Add(this.lblPriceName);
            this.panel3.Controls.Add(this.lblCodeValue);
            this.panel3.Controls.Add(this.lblCodeName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 103);
            this.panel3.TabIndex = 5;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductName.Location = new System.Drawing.Point(13, 50);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(198, 37);
            this.lblProductName.TabIndex = 13;
            this.lblProductName.Text = "Имя товара";
            // 
            // lblSumValue
            // 
            this.lblSumValue.AutoSize = true;
            this.lblSumValue.Location = new System.Drawing.Point(917, 11);
            this.lblSumValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumValue.Name = "lblSumValue";
            this.lblSumValue.Size = new System.Drawing.Size(15, 16);
            this.lblSumValue.TabIndex = 11;
            this.lblSumValue.Text = "_";
            // 
            // lblSumName
            // 
            this.lblSumName.AutoSize = true;
            this.lblSumName.Location = new System.Drawing.Point(846, 11);
            this.lblSumName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumName.Name = "lblSumName";
            this.lblSumName.Size = new System.Drawing.Size(57, 16);
            this.lblSumName.TabIndex = 12;
            this.lblSumName.Text = "Сумма :";
            // 
            // lblCountValue
            // 
            this.lblCountValue.AutoSize = true;
            this.lblCountValue.Location = new System.Drawing.Point(757, 11);
            this.lblCountValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountValue.Name = "lblCountValue";
            this.lblCountValue.Size = new System.Drawing.Size(15, 16);
            this.lblCountValue.TabIndex = 9;
            this.lblCountValue.Text = "_";
            // 
            // lblCountName
            // 
            this.lblCountName.AutoSize = true;
            this.lblCountName.Location = new System.Drawing.Point(653, 11);
            this.lblCountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountName.Name = "lblCountName";
            this.lblCountName.Size = new System.Drawing.Size(92, 16);
            this.lblCountName.TabIndex = 10;
            this.lblCountName.Text = "Количество :";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Location = new System.Drawing.Point(264, 11);
            this.lblPriceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(15, 16);
            this.lblPriceValue.TabIndex = 7;
            this.lblPriceValue.Text = "_";
            // 
            // lblPriceName
            // 
            this.lblPriceName.AutoSize = true;
            this.lblPriceName.Location = new System.Drawing.Point(204, 11);
            this.lblPriceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceName.Name = "lblPriceName";
            this.lblPriceName.Size = new System.Drawing.Size(47, 16);
            this.lblPriceName.TabIndex = 8;
            this.lblPriceName.Text = "Цена :";
            // 
            // lblCodeValue
            // 
            this.lblCodeValue.AutoSize = true;
            this.lblCodeValue.Location = new System.Drawing.Point(65, 11);
            this.lblCodeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeValue.Name = "lblCodeValue";
            this.lblCodeValue.Size = new System.Drawing.Size(15, 16);
            this.lblCodeValue.TabIndex = 5;
            this.lblCodeValue.Text = "_";
            // 
            // lblCodeName
            // 
            this.lblCodeName.AutoSize = true;
            this.lblCodeName.Location = new System.Drawing.Point(16, 11);
            this.lblCodeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeName.Name = "lblCodeName";
            this.lblCodeName.Size = new System.Drawing.Size(38, 16);
            this.lblCodeName.TabIndex = 6;
            this.lblCodeName.Text = "Код :";
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Наименование";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.DataPropertyName = "Count";
            this.colCount.HeaderText = "Количество";
            this.colCount.Name = "colCount";
            // 
            // colSum
            // 
            this.colSum.DataPropertyName = "Sum";
            this.colSum.HeaderText = "Сумма";
            this.colSum.Name = "colSum";
            this.colSum.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Products";
            this.Text = "CashierInterface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketProductBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storedProductBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblSumValue;
        private System.Windows.Forms.Label lblSumName;
        private System.Windows.Forms.Label lblCountValue;
        private System.Windows.Forms.Label lblCountName;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblPriceName;
        private System.Windows.Forms.Label lblCodeValue;
        private System.Windows.Forms.Label lblCodeName;
        private System.Windows.Forms.Label lblStoredProductsCountValue;
        private System.Windows.Forms.Label lblStoredProductsCountName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalSumName;
        private System.Windows.Forms.Label lblTotalSumValue;
        private System.Windows.Forms.ComboBox listStoredProducts;
        private System.Windows.Forms.BindingSource storedProductBindingSource;
        private System.Windows.Forms.BindingSource basketProductBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSum;
    }
}