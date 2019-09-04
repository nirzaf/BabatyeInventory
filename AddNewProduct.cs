using System;
using System.Windows.Forms;

namespace BabatyeInventory
{
    public partial class AddNewProduct : Form
    {

        public Main main;
        public string SKUNumber = "";
        readonly Cloth cloth = new Cloth();
        DAL Dal = new DAL();

        public AddNewProduct(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            DisplayTextBoxes();
        }

        public void DisplayTextBoxes()
        {
            SKUNumber = main.TxtSKUNum.Text;
            if (!string.IsNullOrEmpty(main.TxtColor.Text))
            {
                TxtNewColor.Text = main.TxtColor.Text;
                TxtNewColor.Enabled = false;
            }
            if (!string.IsNullOrEmpty(main.TxtSize.Text))
            {
                TxtNewSize.Text = main.TxtSize.Text;
                TxtNewSize.Enabled = false;
            }                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        public void AddNewItem()
        {
            SKUNumber = main.TxtSKUNum.Text;
            
            if (TxtNewColor.Text.Trim() != "")
            {
                TxtNewColor.Enabled = false;
                TxtNewColor.Text = main.TxtColor.Text;
            }
            if (TxtNewSize.Text.Trim() != "")
            {
                TxtNewSize.Enabled = false;
                TxtNewSize.Text = main.TxtSize.Text;
            }

            if (!string.IsNullOrEmpty(SKUNumber))
            {
                cloth.SKUNumber = SKUNumber;
                if (TxtNewColor.Text.Trim()!="")
                {
                    cloth.Color = TxtNewColor.Text.Trim();
                    if (TxtNewSize.Text.Trim()!="")
                    {
                        cloth.Size = TxtNewSize.Text.Trim();
                        if (TxtNewName.Text.Trim()!="")
                        {
                            cloth.Name = TxtNewName.Text.Trim();
                            int Result = Dal.AddNewCloth(cloth);
                            if (Result > 0)
                            {
                                MessageBox.Show("New Item Added Successfully");
                                main.LoadDGV();
                                main.HideTextBoxes();
                            }
                            else
                            {
                                MessageBox.Show("Something went Wrong");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product Name cannot be empty");
                            TxtNewName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Size cannot be empty");
                        TxtNewSize.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Color cannot be empty");
                    TxtNewColor.Focus();
                }
            }
            else
            {
                MessageBox.Show("SKU Number cannot be empty");
            }
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AddNewItem();
            }
        }
    }
}
