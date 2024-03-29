
namespace WindownForm
{
    partial class frmPainting
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
            this.lblCurrentPos = new System.Windows.Forms.Label();
            this.btnLine = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Area = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Area)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentPos
            // 
            this.lblCurrentPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentPos.AutoSize = true;
            this.lblCurrentPos.Location = new System.Drawing.Point(12, 445);
            this.lblCurrentPos.Name = "lblCurrentPos";
            this.lblCurrentPos.Size = new System.Drawing.Size(53, 20);
            this.lblCurrentPos.TabIndex = 0;
            this.lblCurrentPos.Text = "label1";
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(12, 22);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 38);
            this.btnLine.TabIndex = 1;
            this.btnLine.Text = "button1";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(156, 96);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(636, 314);
            this.Area.TabIndex = 2;
            this.Area.TabStop = false;
            this.Area.Paint += new System.Windows.Forms.PaintEventHandler(this.Area_Paint);
            this.Area.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Area_MouseClick);
            this.Area.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Area_MouseDown);
            this.Area.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Area_MouseMove);
            this.Area.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Area_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(12, 66);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 38);
            this.btnFill.TabIndex = 1;
            this.btnFill.Text = "button1";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // frmPainting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.lblCurrentPos);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPainting";
            this.Text = "Painting";
            ((System.ComponentModel.ISupportInitialize)(this.Area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentPos;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFill;
    }
}