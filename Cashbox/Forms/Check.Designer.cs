namespace Cashbox.Forms
{
    partial class CheckForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbxSumToPayment = new System.Windows.Forms.TextBox();
            this.lblSum2Payment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(373, 132);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Оплатить";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(281, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(14, 18);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(284, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Введите предложенную покупателем сумму не менее ";
            this.lblInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxSumToPayment
            // 
            this.tbxSumToPayment.Location = new System.Drawing.Point(12, 83);
            this.tbxSumToPayment.Name = "tbxSumToPayment";
            this.tbxSumToPayment.Size = new System.Drawing.Size(436, 20);
            this.tbxSumToPayment.TabIndex = 3;
            // 
            // lblSum2Payment
            // 
            this.lblSum2Payment.AutoSize = true;
            this.lblSum2Payment.Location = new System.Drawing.Point(14, 46);
            this.lblSum2Payment.Name = "lblSum2Payment";
            this.lblSum2Payment.Size = new System.Drawing.Size(0, 13);
            this.lblSum2Payment.TabIndex = 4;
            this.lblSum2Payment.Click += new System.EventHandler(this.lblSum2Payment_Click);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 166);
            this.Controls.Add(this.lblSum2Payment);
            this.Controls.Add(this.tbxSumToPayment);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Check";
            this.Text = "Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox tbxSumToPayment;
        private System.Windows.Forms.Label lblSum2Payment;
    }
}