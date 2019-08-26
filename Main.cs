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
                    MessageBox.Show("Something Went Wrong");
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
    }
}
