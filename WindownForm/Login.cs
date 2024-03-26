using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindownForm
{
    public partial class Login : Form
    {
        private string user = "";
        private string pass = "";
        public Login()
        {
            //Properties.Settings.Default.user = "Admin";
            //Properties.Settings.Default.Save();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == user && txtPassword.Text == pass)
            {
                MainForm main = new MainForm(txtUserName.Text, txtPassword.Text);
                main.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Nhập thông tin sai");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            user = Properties.Settings.Default.user;
            pass = Properties.Settings.Default.pass;
        }
    }
}
