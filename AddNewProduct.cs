using System;
using System.Windows.Forms;

namespace BabatyeInventory
{
    public partial class AddNewProduct : Form
    {

        public Main main;
        public string SKUNumber = "";
        readonly Cloth cloth = new Cloth();
        DAL dal = new DAL();

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
                TxtColor.Text = main.TxtColor.Text;
                TxtColor.Enabled = false;
            }
            if (!string.IsNullOrEmpty(main.TxtSize.Text))
            {
                TxtSize.Text = main.TxtSize.Text;
                TxtSize.Enabled = false;
            }                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        public void AddNewItem()
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
                cloth.SKUNumber = SKUNumber;
                if (!string.IsNullOrEmpty(TxtColor.Text.Trim()))
                {
                    cloth.Color = TxtColor.Text.Trim();
                    if (!string.IsNullOrEmpty(TxtSize.Text.Trim()))
                    {
                        cloth.Size = TxtSize.Text.Trim();
                        if (!string.IsNullOrEmpty(TxtName.Text.Trim()))
                        {
                            cloth.Name = TxtName.Text.Trim();
                            int Result = dal.AddNewCloth(cloth);
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
                            TxtName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Size cannot be empty");
                        TxtSize.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Color cannot be empty");
                    TxtColor.Focus();
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
