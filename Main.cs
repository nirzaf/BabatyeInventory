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
            InsertProduct();
        }

        public void InsertProduct()
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
                    LoadDGV();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("This item does not exist, would you like add it?", "Item Not Exist!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cloth.SKUNumber = TxtSKUNum.Text.Trim();
                        TxtColor.Text = cloth.ProductColor();
                        TxtSize.Text = cloth.ProductSize();
                        //TxtName.Text = cloth.ProductName();
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
            LoadDGV();
        }

        public void LoadDGV()
        {
            DGVExistingItems.DataSource = dal.LoadDGV();

            //set autosize mode
            DGVExistingItems.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVExistingItems.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVExistingItems.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //datagrid has calculated it's widths so we can store them
            for (int i = 0; i <= DGVExistingItems.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = DGVExistingItems.Columns[i].Width;
                //remove autosizing
                DGVExistingItems.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                DGVExistingItems.Columns[i].Width = colw;
            }

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

            if (TxtColor.Text.Trim() != "")
                TxtColor.Enabled = false;

            if (TxtSize.Text.Trim() != "")
                TxtSize.Enabled = false;

            BtnAddNewItem.Visible = true;
            BtnAddNewItem.Enabled = true;
            BtnInsert.Enabled = false;
        }

        private void BtnAddNewItem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtSKUNum.Text.Trim()))
            {
                cloth.SKUNumber = TxtSKUNum.Text.Trim();
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
                                LoadDGV();
                                HideTextBoxes();
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

        private void TxtSKUNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                InsertProduct();
            }
        }

        private void TxtSKUNum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                InsertProduct();
            }
        }

        private void TxtSKUNum_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSKUNum.Text))
            {
                cloth.SKUNumber = TxtSKUNum.Text.Trim();
                label1.Text = cloth.ProductColor();
                label2.Text = cloth.ProductSize();
                label3.Text = cloth.ProductName();
            }
        }
    }
}
