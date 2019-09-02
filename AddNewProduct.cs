using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabatyeInventory
{
    public partial class AddNewProduct : Form
    {

        public Main main;
        public string SKUNumber = "";
        readonly Cloth cl = new Cloth();
        DAL dal = new DAL();

        public AddNewProduct(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void BtnAddNow_Click(object sender, EventArgs e)
        {

        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            DisplayTextBoxes();
        }

        public void DisplayTextBoxes()
        {
            SKUNumber = main.TxtSKUNum.Text;
            TxtColor.Text = main.TxtColor.Text;
            TxtSize.Text = main.TxtSize.Text;

            if (TxtColor.Text.Trim() != "")
                TxtColor.Enabled = false;

            if (TxtSize.Text.Trim() != "")
                TxtSize.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SKUNumber = main.TxtSKUNum.Text;
            TxtColor.Text = main.TxtColor.Text;
            TxtSize.Text = main.TxtSize.Text;

            if (TxtColor.Text.Trim() != "")
                TxtColor.Enabled = false;

            if (TxtSize.Text.Trim() != "")
                TxtSize.Enabled = false;

            if (!string.IsNullOrEmpty(SKUNumber))
            {
                cl.SKUNumber = SKUNumber;
                if (!string.IsNullOrEmpty(TxtColor.Text.Trim()))
                {
                    cl.Color = TxtColor.Text.Trim();
                    if (!string.IsNullOrEmpty(TxtSize.Text.Trim()))
                    {
                        cl.Size = TxtSize.Text.Trim();
                        if (!string.IsNullOrEmpty(TxtName.Text.Trim()))
                        {
                            cl.Name = TxtName.Text.Trim();
                            int Result = dal.AddNewCloth(cl);
                            if (Result > 0)
                            {
                                MessageBox.Show("New Item Added Successfully");
                                main.LoadDGV();
                            }
                            else
                            {
                                MessageBox.Show("Something went Wrong");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Size cannot be empty");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Size cannot be empty");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Color cannot be empty");
                    return;
                }
            }
            else
            {
                MessageBox.Show("SKU Number cannot be empty");
                return;
            }
        }

        private void TxtSize_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
