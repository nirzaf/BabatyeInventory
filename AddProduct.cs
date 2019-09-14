using System;
using System.Windows.Forms;

namespace BabatyeInventory
{
    public partial class AddProduct : Form
    {
        public string SKUNumber = "";
        Cloth cloth = new Cloth();
        DAL dal = new DAL();
        Main main = new Main();

        public AddProduct()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)//for draging window_start
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            TxtColor1.Text = Main.NewProductColor;
            TxtSize1.Text = Main.NewProductSize;
            TxtName1.Text = Main.NewProductName;
            SKUNumber = Main.NewSKUNumber;
            if (TxtColor1.Text != "")
            {
                TxtColor1.Enabled = false;
            }
            if (TxtSize1.Text != "")
            {
                TxtSize1.Enabled = false;
            }
            if (TxtName1.Text != "")
            {
                TxtName1.Enabled = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        public void AddNewItem()
        {
            if (!string.IsNullOrEmpty(SKUNumber))
            {
                cloth.SKUNumber = SKUNumber;
                if (!string.IsNullOrEmpty(TxtColor1.Text.Trim()))
                {
                    cloth.Color = TxtColor1.Text.Trim();
                    if (!string.IsNullOrEmpty(TxtSize1.Text.Trim()))
                    {
                        cloth.Size = TxtSize1.Text.Trim();
                        if (!string.IsNullOrEmpty(TxtName1.Text.Trim()))
                        {
                            cloth.Name = TxtName1.Text.Trim();
                            int Result = dal.AddNewCloth(cloth);
                            if (Result > 0)
                            {
                                MessageBox.Show("New Item Added Successfully");
                                Main.TotalProducts++;
                                Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Something went Wrong");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product Name cannot be empty");
                            TxtName1.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Size cannot be empty");
                        TxtSize1.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Color cannot be empty");
                    TxtColor1.Focus();
                }
            }
            else
            {
                MessageBox.Show("SKU Number cannot be empty");
            }
        }

        private void TxtName1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AddNewItem();
            }
        }

        private void TxtSize1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AddNewItem();
            }
        }

        private void TxtColor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AddNewItem();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AddProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Dispose();
            }
        }
    }
}
