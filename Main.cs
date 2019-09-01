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
    public partial class Main : Form
    {
        readonly Cloth cloth = new Cloth();
        readonly DAL dal = new DAL();

        public Main()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            cloth.SKUNumber = TxtSKUNum.Text.Trim();
            cloth.Name = TxtSKUNum.Text.Substring(0, 6);
            cloth.Color = cloth.ProductColor();
            cloth.Size = cloth.ProductSize();

            int Result = dal.InsertCloth(cloth);
            try
            {
                if (Result > 0)
                {
                    MessageBox.Show("Product Added Successfully");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("This item does not exist, would you like add it?", "Item Not Exist!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DisplayTextBoxes();
                       
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cloth.SKUNumber = TxtSKUNum.Text.Trim();
            label1.Text = cloth.ProductColor();
            label2.Text = cloth.ProductSize();
            label3.Text = cloth.ProductName();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            HideTextBoxes();
        }

        public void HideTextBoxes()
        {
            TxtColor.Visible = false;
            TxtSize.Visible = false;
            TxtName.Visible = false;
            BtnAddNewItem.Visible = false;
            BtnAddNewItem.Enabled = false;
            BtnInsert.Enabled = true;
        }

        public void DisplayTextBoxes()
        {
            TxtColor.Visible = true;
            TxtSize.Visible = true;
            TxtName.Visible = true;
            BtnAddNewItem.Visible = true;
            BtnAddNewItem.Enabled = true;
            BtnInsert.Enabled = false;
        }

        private void BtnAddNewItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtSKUNum.Text.Trim()))
            {
                cloth.SKUNumber = TxtSKUNum.Text.Trim();
            }else
            {
                MessageBox.Show("SKU Number cannot be empty");
            }

            if (string.IsNullOrEmpty(TxtColor.Text.Trim()))
            {
                cloth.Color = TxtColor.Text.Trim();
            }
            else
            {
                MessageBox.Show("Color cannot be empty");
            }

            if (string.IsNullOrEmpty(TxtSize.Text.Trim()))
            {
                cloth.Size = TxtSize.Text.Trim();
            }
            else
            {
                MessageBox.Show("Size cannot be empty");
            }

            if (string.IsNullOrEmpty(TxtName.Text.Trim()))
            {
                cloth.Name = TxtName.Text.Trim();
            }
            else
            {
                MessageBox.Show("Size cannot be empty");
            }

            int Result = dal.AddNewCloth(cloth);
            if (Result > 0)
            {
                MessageBox.Show("New Item Added Successfully");
                HideTextBoxes();
            }
            else
            {
                MessageBox.Show("Something went Wrong");
            }
        }
    }
}
