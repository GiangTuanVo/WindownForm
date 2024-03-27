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
using WindownForm.Model;

namespace WindownForm
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
            dtpNgay.Format = DateTimePickerFormat.Custom;
            dtpNgay.CustomFormat=("dd/MM/yyyy");
        }

        private void frmListBox_Load(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien("Nguyễn Văn Tèo", 1234, DateTime.ParseExact("05/06/1987", "dd/MM/yyyy", CultureInfo.InvariantCulture));
            listBox1.Items.Add(sinhVien);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SinhVien sv = listBox1.SelectedItem as SinhVien;
                txtTen.Text = sv.TenSV;
                txtMa.Text = sv.MaSV.ToString();
                dtpNgay.Value = sv.BirthDay;

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SinhVien sv = listBox1.SelectedItem as SinhVien;
                sv.TenSV = txtTen.Text;
                int index = listBox1.SelectedIndex;
                listBox1.Items[index] = sv;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
