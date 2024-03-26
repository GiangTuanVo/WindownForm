using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindownForm
{
    public partial class BasicControl : Form
    {
        public BasicControl()
        {
            InitializeComponent();
        }

        private void BasicControl_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy"; 

            //MessageBox.Show("Form đang mở", "Thông tin", 
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void BasicControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tắt form hay không?", "Thông tin",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.OK)
            {
                e.Cancel = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void txtTenNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(txtTenNV.Text);
            }
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            txtCopy.Text = txtTenNV.Text;
        }

        private void txtTuoiNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtTuoiNV.Text, out int val))
                {
                    MessageBox.Show($"Tuổi : {val}");
                }
                else
                {
                    MessageBox.Show("Nhập tuổi không đúng");
                }
            }
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtTuoiNV.Text, out int val))
            {
                txtAdd.AppendText($"{txtTenNV.Text}, {txtTuoiNV.Text} \r\n");
                //txtAdd.Text = txtAdd.Text + $"{txtTenNV.Text}, {txtTuoiNV.Text} \r\n";
            }
            else
            {
                MessageBox.Show("Nhập tuổi không đúng");
            }

        }

        private void btnAddText_MouseHover(object sender, EventArgs e)
        {
            btnAddText.BackColor = Color.Green;
        }

        private void btnAddText_MouseLeave(object sender, EventArgs e)
        {
            btnAddText.BackColor = SystemColors.Control;
        }

        private void rbtnRedColor_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnBlueColor.Checked)
                txtAdd.ForeColor = Color.Red;
        }

        private void rbtnBlueColor_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnBlueColor.Checked)
                txtAdd.ForeColor = Color.Green;
        }

        private void chkFontBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFontBold.Checked)
            {
                txtAdd.Font = new Font(
                    txtAdd.Font.Name,
                    txtAdd.Font.Size,
                    txtAdd.Font.Style ^ FontStyle.Bold);
            }
        }

        private void chkFontItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFontItalic.Checked)
            {
                txtAdd.Font = new Font(
                    txtAdd.Font.Name,
                    txtAdd.Font.Size,
                    txtAdd.Font.Style ^ FontStyle.Italic);
            }
        }
    }
}

