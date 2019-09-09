using Microsoft.VisualBasic.FileIO;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BabatyeInventory
{
    public partial class Main : Form
    {
        public static string NewProductColor = "";
        public static string NewProductSize = "";
        public static string NewProductName = "";
        public static string NewSKUNumber = "";
        readonly Cloth cloth = new Cloth();
        readonly DAL dal = new DAL();
        public string filePath = "";
        public int TotalRows = 0;
        public int Count = 100;

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
            if (!string.IsNullOrEmpty(TxtColor.Text.Trim()))
            {
                cloth.Color = cloth.ProductColor();
            }
            else
            {
                TxtColor.Enabled = true;
                TxtColor.Focus();
            }
            if (!string.IsNullOrEmpty(TxtSize.Text.Trim()))
            {
                cloth.Size = cloth.ProductSize();
            }
            else
            {
                TxtSize.Enabled = true;
                TxtSize.Focus();
            }

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
            BtnLoad.Enabled = false;
            LblMessage.Text = "";
        }

        public void LoadDGV()
        {
            DGVExistingItems.DataSource = dal.LoadDGV();

            //set autosize mode
            DGVExistingItems.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            for (int i = 0; i < DGVExistingItems.Columns.Count; i = i + 2)
                DGVExistingItems.Columns[i].DefaultCellStyle.BackColor = Color.LightGray;


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
                TxtSKUNum.Focus();
            }
        }

        private void TxtSKUNum_KeyPress(object sender, KeyPressEventArgs e)
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

        void OpenKeywordsFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            OpenFileDialog fileDialog = sender as OpenFileDialog;
            string selectedFile = fileDialog.FileName;
            if (string.IsNullOrEmpty(selectedFile) || selectedFile.Contains(".lnk"))
            {
                MessageBox.Show("Please select a valid Excel File");
                e.Cancel = true;
            }
            return;
        }

        private void BtnReadFromExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog Ofd = new OpenFileDialog
            {
                Multiselect = false,
                ValidateNames = true,
                DereferenceLinks = false, // Will return .lnk in shortcuts.
                //Filter = @" Excel Files(.xls)|*.xls| Excel Files(.xlsx) | *.xlsx | Excel Files(*.xlsm) | *.xlsm | CSV Files(*.csv) | *.csv"
            };
            Ofd.FileOk += new System.ComponentModel.CancelEventHandler(OpenKeywordsFileDialog_FileOk);
            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = Ofd.FileName;
                LblMessage.Text = "Importing excel file...";
            }
            TotalRows = 0;           
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;
            xlApp = new Excel.Application();
            if (filePath != "")
            {
                try
                {
                    int totalRows = 0;
                    xlWorkBook = xlApp.Workbooks.Open(filePath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    totalRows = xlWorkSheet.UsedRange.Rows.Count;
                    PBLoading.Visible = true;
                    PBLoading.Maximum = totalRows; // your loop max no.
                    PBLoading.Minimum = 0;
                    range = xlWorkSheet.UsedRange.Columns[1];
                    rw = range.Rows.Count;
                    cl = 1;
                    for (rCnt = 2; rCnt <= rw; rCnt++)
                    {
                        for (cCnt = 1; cCnt <= cl; cCnt++)
                        {
                            TotalRows++;
                            PBLoading.Value = TotalRows;
                        }
                    }
                    LoadDGV();
                    xlWorkBook.Close(true, null, null);
                    xlApp.Quit();
                    timer1.Enabled = true;
                    LblMessage.ForeColor = Color.Green;
                    LblMessage.Text = TotalRows.ToString() + " Rows Imported Successfully!";
                    BtnLoad.Enabled = true;
                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            PanelAddedItems.Visible = true;
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
            if (filePath != "")
            {
                xlWorkBook = xlApp.Workbooks.Open(filePath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                range = xlWorkSheet.UsedRange.Columns[1];
                rw = range.Rows.Count;
                cl = 1;
                int TotalProducts = 0;
                for (rCnt = 2; rCnt <= rw; rCnt++)
                {
                    for (cCnt = 1; cCnt <= cl; cCnt++)
                    {
                        str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
                        if (!string.IsNullOrEmpty(str))
                        {
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
                                    NewProductColor = TxtColor.Text.Trim();
                                    NewProductSize = TxtSize.Text.Trim();
                                    NewProductName = TxtName.Text.Trim();
                                    NewSKUNumber = TxtSKUNum.Text.Trim();
                                    AddProduct Ap = new AddProduct();
                                    Ap.ShowDialog();
                                }
                            }
                            TotalProducts += Result;
                            LblAddedItems.Text = TotalProducts.ToString();
                            LoadDGV();
                        }
                    }
                }

                LoadDGV();
                xlWorkBook.Close(true, null, null);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
                DialogResult dr = MessageBox.Show(TotalProducts.ToString() + " Products Added Successfully!, would you like to delete excel source file?", "Confirmation to remove the source file!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin, UICancelOption.ThrowException);
                BtnLoad.Enabled = false;
                PanelAddedItems.Visible = false;
            }
            else
            {
                MessageBox.Show("File Name Not Selected");
            }
        }

        private void TxtFilterBySKU_KeyUp(object sender, KeyEventArgs e)
        {
            (DGVExistingItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("SKU LIKE '{0}%' OR SKU LIKE '% {0}%' OR NAME LIKE '{0}%' OR NAME LIKE '% {0}%' OR Size LIKE '{0}%' OR Size LIKE '% {0}%' OR Color LIKE '{0}%' OR Color LIKE '% {0}%' ", TxtFilterBySKU.Text);
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AddNewItem();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblMessage.Text = "";
            PBLoading.Visible = false;
            LblMessage.ForeColor = Color.Red;
            timer2.Enabled = false ;
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (LblMessage.Text == "")
            {
                LblMessage.Text = TotalRows.ToString() + " Rows Imported Successfully!";
            }
            else
            {
                LblMessage.Text = "";
            }
        }

        private void TxtSKUNum_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                InsertProduct();
            }
        }
    }
}
