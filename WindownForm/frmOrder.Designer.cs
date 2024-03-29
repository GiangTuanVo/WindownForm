
namespace WindownForm
{
    partial class frmOrder
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
            this.listProductInput = new System.Windows.Forms.ListBox();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.layoutTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTableName = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProductInput
            // 
            this.listProductInput.FormattingEnabled = true;
            this.listProductInput.ItemHeight = 21;
            this.listProductInput.Location = new System.Drawing.Point(47, 119);
            this.listProductInput.Name = "listProductInput";
            this.listProductInput.Size = new System.Drawing.Size(325, 214);
            this.listProductInput.TabIndex = 0;
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 21;
            this.listOrder.Location = new System.Drawing.Point(526, 119);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(391, 214);
            this.listOrder.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(398, 141);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(122, 27);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(398, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 42);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(776, 338);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(141, 41);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(398, 278);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(122, 42);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New Table";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(526, 86);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(100, 27);
            this.txtTable.TabIndex = 1;
            // 
            // layoutTable
            // 
            this.layoutTable.Location = new System.Drawing.Point(47, 393);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.Size = new System.Drawing.Size(870, 102);
            this.layoutTable.TabIndex = 3;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(650, 338);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(115, 41);
            this.btnAddTable.TabIndex = 2;
            this.btnAddTable.Text = "ADD";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Table Name";
            // 
            // cmbTableName
            // 
            this.cmbTableName.FormattingEnabled = true;
            this.cmbTableName.Items.AddRange(new object[] {
            "Table 01",
            "Table 02",
            "Table 03"});
            this.cmbTableName.Location = new System.Drawing.Point(399, 195);
            this.cmbTableName.Name = "cmbTableName";
            this.cmbTableName.Size = new System.Drawing.Size(121, 29);
            this.cmbTableName.TabIndex = 5;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(526, 338);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(115, 42);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 516);
            this.Controls.Add(this.cmbTableName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.layoutTable);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.listProductInput);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProductInput;
        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.FlowLayoutPanel layoutTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTableName;
        private System.Windows.Forms.Button btnPay;
    }
}