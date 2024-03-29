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
    public partial class frmListCheckBox : Form
    {
        public frmListCheckBox()
        {
            InitializeComponent();
        }

        private void frmListCheckBox_Load(object sender, EventArgs e)
        {
            checkListLeft.Items.AddRange(new string[] { "Tuấn", "Giang", "Hùng","Dung","Quoc" });
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkListLeft.Items.Add(txtCheckBoxName.Text);
        }

        private void btnMoveToRight_Click(object sender, EventArgs e)
        {
            foreach (int item in checkListLeft.SelectedIndices)
            {
                checkListRight.Items.Add(checkListLeft.Items[item]);
                checkListLeft.Items.RemoveAt(item);
            }
        }

        private void btnMoveAllToRight_Click(object sender, EventArgs e)
        {
            checkListRight.Items.AddRange(checkListLeft.Items);
            checkListLeft.Items.Clear();
        }

        private void btnMoveToLeft_Click(object sender, EventArgs e)
        {
            foreach (int item in checkListRight.SelectedIndices)
            {
                checkListLeft.Items.Add(checkListRight.Items[item]);
                checkListRight.Items.RemoveAt(item);
            }
        }

        private void btnMoveAllToLeft_Click(object sender, EventArgs e)
        {
            checkListLeft.Items.AddRange(checkListRight.Items);
            checkListRight.Items.Clear();
        }

        private void checkListLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get index
            //CheckedListBox.CheckedIndexCollection checkedIndex = checkListLeft.CheckedIndices;
            //Gettext
            CheckedListBox.CheckedItemCollection checkedIndex = checkListLeft.CheckedItems;
            string strCheck = "";
            if (checkedIndex.Count > 0)
            {
                foreach (var i in checkedIndex)
                {
                    strCheck += $"Selected : {i}\r\n";
                }
                MessageBox.Show(strCheck);
            }
        }
    }
}
