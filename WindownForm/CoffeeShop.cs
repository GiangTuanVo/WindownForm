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
using WindownForm.ModelQuanCafe;

namespace WindownForm
{
    public partial class CoffeeShop : Form
    {
        ListProduct listProduct;
        string Path = Application.StartupPath + "\\File.csv";
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void btnAddSp_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product(int.Parse(txtNoSp.Text), txtKindSp.Text, txtNameSp.Text, int.Parse(txtQantitySp.Text), int.Parse(txtPriceSp.Text));
                lstProduct.Items.Add(product);
                ClearAddSP();
            }
            catch (Exception)
            {
            }

        }

        private void btnRepairSp_Click(object sender, EventArgs e)
        {
            if (lstProduct.SelectedIndex != -1)
            {
                int index = lstProduct.SelectedIndex;
                Product product = lstProduct.SelectedItem as Product;
                product.No = int.Parse(txtNoSp.Text);
                product.Name = txtNameSp.Text;
                product.Price = int.Parse(txtPriceSp.Text);
                product.Quantity = int.Parse(txtQantitySp.Text);
                product.Type = txtKindSp.Text;
                //Update nhân viên
                lstProduct.Items[index] = product;
            }
        }
        private void ClearAddSP()
        {
            txtNoSp.Text = "";
            txtNameSp.Text = "";
            txtPriceSp.Text = "";
            txtQantitySp.Text = "";
        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduct.SelectedIndex != -1)
            {
                Product product = lstProduct.SelectedItem as Product;
                txtNoSp.Text = product.No.ToString();
                txtNameSp.Text = product.Name;
                txtPriceSp.Text = product.Price.ToString();
                txtQantitySp.Text = product.Quantity.ToString();
                txtKindSp.Text = product.Type;
            }
        }

        private void btnClearSp_Click(object sender, EventArgs e)
        {
            if (lstProduct.SelectedIndex != -1)
            {
                lstProduct.Items.RemoveAt(lstProduct.SelectedIndex);
            }
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            if (cmbTable.Text != "")
            {
                foreach (Control item in layoutTable.Controls)
                {
                    if (item.Text == cmbTable.Text) return;
                }
            }
            txtTableName.Text = cmbTable.Text;
            btnAddOrder.Enabled = true;
            listProduct = new ListProduct();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (lstProduct.SelectedIndex != -1 && Versioned.IsNumeric(txtAmout.Text))
            {
                Product product = lstProduct.SelectedItem as Product;

                Product newProdcut = new Product();

                newProdcut.Name = product.Name;
                newProdcut.No = product.No;
                newProdcut.Price = product.Price;
                newProdcut.Quantity = product.Quantity;
                newProdcut.Type = product.Type;

                listProduct.AddProduct(newProdcut, int.Parse(txtAmout.Text));
                lstOrder.Items.Add(newProdcut);
                txtTotalPrice.Text = listProduct.TotalPrice().ToString();
            }
        }

        private void btnAddTale_Click(object sender, EventArgs e)
        {
            if (!CheckExist(txtTableName.Text))
            {
                DialogResult ret = MessageBox.Show("Are you update Table !", "Infomation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                switch (ret)
                {
                    case DialogResult.OK:
                        ClearItem(txtTableName.Text);
                        break;
                    case DialogResult.Cancel:
                        return;
                    default:
                        break;
                }
            }
            Button button = new Button()
            {
                Text = txtTableName.Text,
                Width = 100,
                Height = 50,
                Tag = listProduct
            };
            button.Click += Button_Click;
            layoutTable.Controls.Add(button);
            Clear();
            btnAddOrder.Enabled = false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ListProduct list = (ListProduct)button.Tag;
            listProduct = new ListProduct();
            listProduct = list;
            lstOrder.Items.Clear();
            
            foreach (Product item in listProduct.Products)
            {
                lstOrder.Items.Add(item);
            }
            txtTotalPrice.Text = listProduct.TotalPrice().ToString();
            txtTableName.Text = button.Text;
        }

        private void Clear()
        {
            txtTableName.Text = "";
            txtTotalPrice.Text = "";
            lstOrder.Items.Clear();
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
            if (lstOrder.Items.Count > 0)
            {
                foreach (Product item in lstOrder.Items)
                {
                    StringBuilder builder = new StringBuilder();
                    builder.AppendLine(item.ToString());
                    File.AppendAllText(Path, builder.ToString());
                }
            }
            ClearItem(txtTableName.Text);
            ClearAddSP();
        }
    }
}
