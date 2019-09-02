using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BabatyeInventory
{
    public partial class Main : Form
    {
        readonly Cloth cloth = new Cloth();
        readonly DAL dal = new DAL();
        private EventWaitHandle waitHandle = new AutoResetEvent(false);

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
            if (!string.IsNullOrEmpty(TxtName.Text.Trim()))
            {
                cloth.Name = TxtName.Text.Trim();
            }
            else
            {
                TxtName.Focus();
            }
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
            PBInsert.Visible = true;
            PBAddNewItem.Visible = false;
        }

        public void DisplayTextBoxes()
        {
            TxtColor.Visible = true;
            TxtSize.Visible = true;
            TxtName.Visible = true;
            PBAddNewItem.Visible = true;

            if (TxtColor.Text.Trim() != "")
                TxtColor.Enabled = false;

            if (TxtSize.Text.Trim() != "")
                TxtSize.Enabled = false;

            BtnAddNewItem.Visible = true;
            BtnAddNewItem.Enabled = true;
            BtnInsert.Enabled = false;
            PBInsert.Visible = false;
        }

        private void BtnAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        public void AddNewItem()
        {
            if (!string.IsNullOrEmpty(TxtSKUNum.Text.Trim()))
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
                                waitHandle.Set();
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

        private void PBInsert_Click(object sender, EventArgs e)
        {
            InsertProduct();
        }

        private void PBAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void BtnReadFromExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog Ofd = new OpenFileDialog();
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                LblFilePath.Text = Ofd.FileName;
            }
        }

        public void ShowMyDialogBox()
        {
            AddNewProduct testDialog = new AddNewProduct(this);

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                TxtName.Text = testDialog.TxtName.Text;

            }
            testDialog.Dispose();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {            
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            string str;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;
            xlApp = new Excel.Application();
            if (LblFilePath.Text != "")
            {
                xlWorkBook = xlApp.Workbooks.Open(LblFilePath.Text, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                range = xlWorkSheet.UsedRange;
                rw = range.Rows.Count;
                cl = range.Columns.Count;
                int TotalProducts = 0;
                for (rCnt = 1; rCnt <= rw; rCnt++)
                {
                    for (cCnt = 1; cCnt <= cl; cCnt++)
                    {
                        str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
                        TxtSKUNum.Text = str;
                        cloth.SKUNumber = TxtSKUNum.Text.Trim();
                        int Result = dal.InsertCloth(cloth);
                        if (Result == 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("This item does not exist, would you like add it?", "Item Not Exist!", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                cloth.SKUNumber = TxtSKUNum.Text.Trim();
                                TxtColor.Text = cloth.ProductColor();
                                TxtSize.Text = cloth.ProductSize();
                                DisplayTextBoxes();
                                ShowMyDialogBox();
                            }
                        }
                        TotalProducts += Result;
                        LoadDGV();
                    }
                }
                MessageBox.Show(TotalProducts.ToString() + " Products Added Successfully ");
                LoadDGV();
                xlWorkBook.Close(true, null, null);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
            else
            {
                MessageBox.Show("File Name Not Selected");
            }
        }
    }
}
