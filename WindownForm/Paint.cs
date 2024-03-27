using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindownForm
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
            dtpBirthDay.Format = DateTimePickerFormat.Custom;
            dtpBirthDay.CustomFormat = ("dd/MM/yyyy");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMNV.Text == "" | txtName.Text == "") return;
            try
            {
                NhanVien nhanVien = new NhanVien(txtName.Text, cmbSex.Text, int.Parse(txtMNV.Text), dtpBirthDay.Text);
                //MessageBox.Show(nhanVien.ToString());
                lstNhanVien.Items.Add(nhanVien);
                txtMNV.Text = "";
                txtName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstNhanVien.SelectedIndex != -1)
            {
                int index = lstNhanVien.SelectedIndex;
                lstNhanVien.Items.RemoveAt(index);
            }

        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            if (lstNhanVien.SelectedIndex != -1)
            {
                int index = lstNhanVien.SelectedIndex;
                NhanVien nv = lstNhanVien.SelectedItem as NhanVien;
                nv.Name = txtName.Text;
                nv.MNV = int.Parse(txtMNV.Text);
                nv.Sex = cmbSex.Text;
                nv.BirthDay = dtpBirthDay.Text;
                //Update nhân viên
                lstNhanVien.Items[index] = nv;
            }
        }

        private void lstNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNhanVien.SelectedIndex != -1)
            {
                NhanVien nv = lstNhanVien.SelectedItem as NhanVien;
                txtName.Text = nv.Name;
                txtMNV.Text = nv.MNV.ToString();
                cmbSex.Text = nv.Sex;
                dtpBirthDay.Value = DateTime.ParseExact(nv.BirthDay, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
        }

        private void btnTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lstNhanVien.Items.Count > 0)
            {
                for (int i = 0; i < lstNhanVien.Items.Count; i++)
                {
                    lstNhanVien.SelectedIndex = i;
                    NhanVien nv = lstNhanVien.SelectedItem as NhanVien;
                    if (nv.MNV == int.Parse(txtSearch.Text))
                    {
                        MessageBox.Show(nv.ToString());
                        break;
                    }
                }
            }
        }
    }
}
