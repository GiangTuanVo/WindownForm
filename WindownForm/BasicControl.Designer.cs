
namespace WindownForm
{
    partial class BasicControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicControl));
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTuoiNV = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAddText = new System.Windows.Forms.Button();
            this.rbtnRedColor = new System.Windows.Forms.RadioButton();
            this.chkFontBold = new System.Windows.Forms.CheckBox();
            this.rbtnBlueColor = new System.Windows.Forms.RadioButton();
            this.chkFontItalic = new System.Windows.Forms.CheckBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 507);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 20);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtTenNV.Location = new System.Drawing.Point(79, 26);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(210, 26);
            this.txtTenNV.TabIndex = 1;
            this.txtTenNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            this.txtTenNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenNV_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tuổi NV:";
            // 
            // txtTuoiNV
            // 
            this.txtTuoiNV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuoiNV.ForeColor = System.Drawing.Color.DeepPink;
            this.txtTuoiNV.Location = new System.Drawing.Point(79, 61);
            this.txtTuoiNV.Name = "txtTuoiNV";
            this.txtTuoiNV.Size = new System.Drawing.Size(210, 26);
            this.txtTuoiNV.TabIndex = 1;
            this.txtTuoiNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTuoiNV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTuoiNV_KeyDown);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(35, 212);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdd.Size = new System.Drawing.Size(430, 181);
            this.txtAdd.TabIndex = 3;
            // 
            // btnAddText
            // 
            this.btnAddText.Location = new System.Drawing.Point(120, 129);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(101, 41);
            this.btnAddText.TabIndex = 4;
            this.btnAddText.Text = "ADD TEXT";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            this.btnAddText.MouseLeave += new System.EventHandler(this.btnAddText_MouseLeave);
            this.btnAddText.MouseHover += new System.EventHandler(this.btnAddText_MouseHover);
            // 
            // rbtnRedColor
            // 
            this.rbtnRedColor.AutoSize = true;
            this.rbtnRedColor.Location = new System.Drawing.Point(10, 22);
            this.rbtnRedColor.Name = "rbtnRedColor";
            this.rbtnRedColor.Size = new System.Drawing.Size(100, 24);
            this.rbtnRedColor.TabIndex = 5;
            this.rbtnRedColor.TabStop = true;
            this.rbtnRedColor.Text = "Red Color";
            this.rbtnRedColor.UseVisualStyleBackColor = true;
            this.rbtnRedColor.CheckedChanged += new System.EventHandler(this.rbtnRedColor_CheckedChanged);
            // 
            // chkFontBold
            // 
            this.chkFontBold.AutoSize = true;
            this.chkFontBold.Location = new System.Drawing.Point(10, 82);
            this.chkFontBold.Name = "chkFontBold";
            this.chkFontBold.Size = new System.Drawing.Size(60, 24);
            this.chkFontBold.TabIndex = 6;
            this.chkFontBold.Text = "Bold";
            this.chkFontBold.UseVisualStyleBackColor = true;
            this.chkFontBold.CheckedChanged += new System.EventHandler(this.chkFontBold_CheckedChanged);
            // 
            // rbtnBlueColor
            // 
            this.rbtnBlueColor.AutoSize = true;
            this.rbtnBlueColor.Location = new System.Drawing.Point(10, 52);
            this.rbtnBlueColor.Name = "rbtnBlueColor";
            this.rbtnBlueColor.Size = new System.Drawing.Size(102, 24);
            this.rbtnBlueColor.TabIndex = 5;
            this.rbtnBlueColor.TabStop = true;
            this.rbtnBlueColor.Text = "Blue Color";
            this.rbtnBlueColor.UseVisualStyleBackColor = true;
            this.rbtnBlueColor.CheckedChanged += new System.EventHandler(this.rbtnBlueColor_CheckedChanged);
            // 
            // chkFontItalic
            // 
            this.chkFontItalic.AutoSize = true;
            this.chkFontItalic.Location = new System.Drawing.Point(10, 110);
            this.chkFontItalic.Name = "chkFontItalic";
            this.chkFontItalic.Size = new System.Drawing.Size(64, 24);
            this.chkFontItalic.TabIndex = 6;
            this.chkFontItalic.Text = "Italic";
            this.chkFontItalic.UseVisualStyleBackColor = true;
            this.chkFontItalic.CheckedChanged += new System.EventHandler(this.chkFontItalic_CheckedChanged);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(79, 93);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(210, 26);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txtTuoiNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐĂNG KÝ THI BẰNG LÁI XE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày:";
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(35, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 98);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chú ý";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnRedColor);
            this.groupBox3.Controls.Add(this.rbtnBlueColor);
            this.groupBox3.Controls.Add(this.chkFontItalic);
            this.groupBox3.Controls.Add(this.chkFontBold);
            this.groupBox3.Location = new System.Drawing.Point(301, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 145);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Theme";
            // 
            // BasicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(508, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lblTime);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(400, 225);
            this.Name = "BasicControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BasicControl_FormClosing);
            this.Load += new System.EventHandler(this.BasicControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuoiNV;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.RadioButton rbtnRedColor;
        private System.Windows.Forms.CheckBox chkFontBold;
        private System.Windows.Forms.RadioButton rbtnBlueColor;
        private System.Windows.Forms.CheckBox chkFontItalic;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}