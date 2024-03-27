
namespace WindownForm
{
    partial class frmListCheckBox
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
            this.checkListLeft = new System.Windows.Forms.CheckedListBox();
            this.checkListRight = new System.Windows.Forms.CheckedListBox();
            this.btnMoveToRight = new System.Windows.Forms.Button();
            this.btnMoveAllToRight = new System.Windows.Forms.Button();
            this.btnMoveToLeft = new System.Windows.Forms.Button();
            this.btnMoveAllToLeft = new System.Windows.Forms.Button();
            this.txtCheckBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkListLeft
            // 
            this.checkListLeft.FormattingEnabled = true;
            this.checkListLeft.Location = new System.Drawing.Point(22, 66);
            this.checkListLeft.Margin = new System.Windows.Forms.Padding(5);
            this.checkListLeft.Name = "checkListLeft";
            this.checkListLeft.Size = new System.Drawing.Size(216, 246);
            this.checkListLeft.TabIndex = 0;
            this.checkListLeft.SelectedIndexChanged += new System.EventHandler(this.checkListLeft_SelectedIndexChanged);
            // 
            // checkListRight
            // 
            this.checkListRight.FormattingEnabled = true;
            this.checkListRight.Location = new System.Drawing.Point(332, 66);
            this.checkListRight.Margin = new System.Windows.Forms.Padding(5);
            this.checkListRight.Name = "checkListRight";
            this.checkListRight.Size = new System.Drawing.Size(216, 246);
            this.checkListRight.TabIndex = 0;
            // 
            // btnMoveToRight
            // 
            this.btnMoveToRight.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToRight.ForeColor = System.Drawing.Color.Green;
            this.btnMoveToRight.Location = new System.Drawing.Point(248, 66);
            this.btnMoveToRight.Margin = new System.Windows.Forms.Padding(5);
            this.btnMoveToRight.Name = "btnMoveToRight";
            this.btnMoveToRight.Size = new System.Drawing.Size(74, 50);
            this.btnMoveToRight.TabIndex = 1;
            this.btnMoveToRight.Text = ">";
            this.btnMoveToRight.UseVisualStyleBackColor = true;
            this.btnMoveToRight.Click += new System.EventHandler(this.btnMoveToRight_Click);
            // 
            // btnMoveAllToRight
            // 
            this.btnMoveAllToRight.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAllToRight.ForeColor = System.Drawing.Color.Red;
            this.btnMoveAllToRight.Location = new System.Drawing.Point(248, 130);
            this.btnMoveAllToRight.Margin = new System.Windows.Forms.Padding(5);
            this.btnMoveAllToRight.Name = "btnMoveAllToRight";
            this.btnMoveAllToRight.Size = new System.Drawing.Size(74, 50);
            this.btnMoveAllToRight.TabIndex = 1;
            this.btnMoveAllToRight.Text = ">>";
            this.btnMoveAllToRight.UseVisualStyleBackColor = true;
            this.btnMoveAllToRight.Click += new System.EventHandler(this.btnMoveAllToRight_Click);
            // 
            // btnMoveToLeft
            // 
            this.btnMoveToLeft.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveToLeft.ForeColor = System.Drawing.Color.Green;
            this.btnMoveToLeft.Location = new System.Drawing.Point(248, 196);
            this.btnMoveToLeft.Margin = new System.Windows.Forms.Padding(5);
            this.btnMoveToLeft.Name = "btnMoveToLeft";
            this.btnMoveToLeft.Size = new System.Drawing.Size(74, 50);
            this.btnMoveToLeft.TabIndex = 1;
            this.btnMoveToLeft.Text = "<";
            this.btnMoveToLeft.UseVisualStyleBackColor = true;
            this.btnMoveToLeft.Click += new System.EventHandler(this.btnMoveToLeft_Click);
            // 
            // btnMoveAllToLeft
            // 
            this.btnMoveAllToLeft.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveAllToLeft.ForeColor = System.Drawing.Color.Red;
            this.btnMoveAllToLeft.Location = new System.Drawing.Point(248, 262);
            this.btnMoveAllToLeft.Margin = new System.Windows.Forms.Padding(5);
            this.btnMoveAllToLeft.Name = "btnMoveAllToLeft";
            this.btnMoveAllToLeft.Size = new System.Drawing.Size(74, 50);
            this.btnMoveAllToLeft.TabIndex = 1;
            this.btnMoveAllToLeft.Text = "<<";
            this.btnMoveAllToLeft.UseVisualStyleBackColor = true;
            this.btnMoveAllToLeft.Click += new System.EventHandler(this.btnMoveAllToLeft_Click);
            // 
            // txtCheckBoxName
            // 
            this.txtCheckBoxName.Location = new System.Drawing.Point(176, 21);
            this.txtCheckBoxName.Name = "txtCheckBoxName";
            this.txtCheckBoxName.Size = new System.Drawing.Size(270, 27);
            this.txtCheckBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Check Box Name :";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.Location = new System.Drawing.Point(465, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmListCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 332);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCheckBoxName);
            this.Controls.Add(this.btnMoveAllToLeft);
            this.Controls.Add(this.btnMoveToLeft);
            this.Controls.Add(this.btnMoveAllToRight);
            this.Controls.Add(this.btnMoveToRight);
            this.Controls.Add(this.checkListRight);
            this.Controls.Add(this.checkListLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmListCheckBox";
            this.Text = "frmListCheckBox";
            this.Load += new System.EventHandler(this.frmListCheckBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkListLeft;
        private System.Windows.Forms.CheckedListBox checkListRight;
        private System.Windows.Forms.Button btnMoveToRight;
        private System.Windows.Forms.Button btnMoveAllToRight;
        private System.Windows.Forms.Button btnMoveToLeft;
        private System.Windows.Forms.Button btnMoveAllToLeft;
        private System.Windows.Forms.TextBox txtCheckBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
    }
}