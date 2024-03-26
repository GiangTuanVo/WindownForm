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
    public partial class MainForm : Form
    {
        private string Addmin = "";
        private string Pass = "";
        public MainForm( string admin, string pass)
        {
            Addmin = admin;
            Pass = pass;
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtUser.Text = Addmin;
            txtPass.Text = Pass;
        }
    }
}
