using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindownForm.Shop;

namespace WindownForm
{
    public partial class frmOrder : Form
    {
        private ListProduct listProduct;
        private string Path = "";
        public frmOrder()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            Path = Application.StartupPath + "\\File.csv";
            Product product1 = new Product(1, "Thức uống", "Coca", 1, 8000);
            listProductInput.Items.Add(product1);
            Product product2 = new Product(2, "Thức uống", "Pepsi", 1, 8000);
            listProductInput.Items.Add(product2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listProductInput.SelectedIndex != -1 && Versioned.IsNumeric(txtAmount.Text))
            {
                Product abc = listProductInput.SelectedItem as Product;
                listProduct.AddProduct(abc, int.Parse(txtAmount.Text));
                listOrder.Items.Add(abc);
                txtTotal.Text = listProduct.TotalPrice().ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (cmbTableName.Text != "")
            {
                foreach (Control item in layoutTable.Controls)
                {
                    if (item.Text == cmbTableName.Text) return;
                }
            }
            txtTable.Text = cmbTableName.Text;
            btnAdd.Enabled = true;
            listProduct = new ListProduct();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (!CheckExist(txtTable.Text))
            {
                DialogResult ret = MessageBox.Show("Are you update Table !", "Infomation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                switch (ret)
                {
                    case DialogResult.OK:
                        ClearItem(txtTable.Text);
                        break;
                    case DialogResult.Cancel:
                        return;
                    default:
                        break;
                }
            }
            Button button = new Button()
            {
                Text = txtTable.Text,
                Width = 100,
                Height = 50,
                Tag = listProduct
            };
            button.Click += Button_Click;
            layoutTable.Controls.Add(button);
            Clear();

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ListProduct list = (ListProduct)button.Tag;
            listProduct = new ListProduct();
            listProduct = list;
            listOrder.Items.Clear();
            foreach (Product item in listProduct.Products)
            {
                listOrder.Items.Add(item);
            }
            //listOrder.DataSource = listProduct.Products;
            txtTotal.Text = listProduct.TotalPrice().ToString();
            txtTable.Text = button.Text;
        }
        private void Clear()
        {
            txtTable.Text = "";
            txtTotal.Text = "";
            listOrder.Items.Clear();
        }
        private bool CheckExist(string text)
        {
            foreach (Control item in layoutTable.Controls)
            {
                if (item.Text == text)
                {
                    return false;
                }
            }
            return true;
        }
        private void ClearItem(string text)
        {
            foreach (Control item in layoutTable.Controls)
            {
                if (item.Text == text)
                {
                    layoutTable.Controls.Remove(item);
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //if (listOrder.Items.Count > 0)
            //{
            //    foreach (Product item in listOrder.Items)
            //    {
            //        StringBuilder builder = new StringBuilder();
            //        builder.AppendLine(item.ToString());
            //        File.AppendAllLines(path, builder);
            //    }
            //}
        }
    }
}
