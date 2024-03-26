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
            checkListLeft.Items.AddRange(new string[] {"Tuấn","Giang","Hùng" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection checkedIndex = checkListLeft.CheckedIndices;
            string strCheck = "";
            foreach (var i in checkedIndex)
            {

            }
            //Hoặc
            for (int i = 0; i < checkListLeft.Items.Count; i++)
            {
                if (checkListLeft.GetItemChecked(i))
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection checkedIndex = checkListLeft.CheckedItems;
            string strCheck = "";
            foreach (var i in checkedIndex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (int item in checkListLeft.SelectedIndices)
            {
                checkListRight.Items.Add(checkListLeft.Items[item]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (int item in checkListRight.SelectedIndices)
            {
                checkListRight.Items.RemoveAt(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkListRight.Items.AddRange(checkListLeft.Items);
            checkListLeft.Items.Clear();
        }
    }
}
