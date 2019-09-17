using Dotmim.Sync;
using Dotmim.Sync.SqlServer;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BabatyeInventory
{
    public partial class Main : Form
    {
        public static string NewProductColor = "";
        public static string NewProductSize = "";
        public static string NewProductName = "";
        public static string NewSkuNumber = "";
        private readonly Cloth _cloth = new Cloth();
        private readonly DAL _dal = new DAL();
        private string _filePath = "";
        private int _totalRows = 0;
        public static int TotalProducts = 0;

        public Main()
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

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            InsertProduct();
        }

        private void InsertProduct()
        {
            _cloth.SKUNumber = TxtSKUNum.Text.Trim();
            if (!string.IsNullOrEmpty(value: TxtName.Text.Trim()))
            {
                _cloth.Name = TxtName.Text.Trim();
            }
            else
            {
                TxtName.Focus();
            }
            if (!string.IsNullOrEmpty(value: TxtColor.Text.Trim()))
            {
                _cloth.Color = _cloth.ProductColor();
            }
            else
            {
                TxtColor.Enabled = true;
                TxtColor.Focus();
            }
            if (!string.IsNullOrEmpty(value: TxtSize.Text.Trim()))
            {
                _cloth.Size = _cloth.ProductSize();
            }
            else
            {
                TxtSize.Enabled = true;
                TxtSize.Focus();
            }

            var result = _dal.InsertCloth(cloth: _cloth);
            try
            {
                if (result > 0)
                {
                    MessageBox.Show(text: @"Product Added Successfully");
                    LoadDgv();
                }
                else
                {
                    var dialogResult = MessageBox.Show(text: @"This item does not exist, would you like add it?", caption: @"Item Not Exist!", buttons: MessageBoxButtons.YesNo);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            _cloth.SKUNumber = TxtSKUNum.Text.Trim();
                            TxtColor.Text = _cloth.ProductColor();
                            TxtSize.Text = _cloth.ProductSize();
                            DisplayTextBoxes();
                            break;
                        case DialogResult.No:
                            return;
                        case DialogResult.None:
                            break;
                        case DialogResult.OK:
                            break;
                        case DialogResult.Cancel:
                            break;
                        case DialogResult.Abort:
                            break;
                        case DialogResult.Retry:
                            break;
                        case DialogResult.Ignore:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _cloth.SKUNumber = TxtSKUNum.Text.Trim();
            label1.Text = _cloth.ProductColor();
            label2.Text = _cloth.ProductSize();
            label3.Text = _cloth.ProductName();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            HideTextBoxes();
            LoadDgv();
            BtnLoad.Enabled = false;
            LblMessage.Text = "";
        }

        private void LoadDgv()
        {
            DGVExistingItems.DataSource = _dal.LoadDGV();

            //set autosize mode
            DGVExistingItems.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //DGVExistingItems.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            for (var i = 0; i < DGVExistingItems.Columns.Count; i += 2)
                DGVExistingItems.Columns[i].DefaultCellStyle.BackColor = Color.LightGray;

            //data grid has calculated it's widths so we can store them
            for (var i = 0; i <= DGVExistingItems.Columns.Count - 1; i++)
            {
                //store auto sized widths
                var colw = DGVExistingItems.Columns[i].Width;
                //remove auto sizing
                DGVExistingItems.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                DGVExistingItems.Columns[i].Width = colw;
            }
        }

        public async System.Threading.Tasks.Task DataSyncAsync()
        {
            // Create 2 Sql Sync providers
            var serverProvider = new SqlSyncProvider(@"workstation id = babatye.mssql.somee.com; packet size = 4096; user id = babatye_SQLLogin_1; pwd=2jdfhb4nco;data source = babatye.mssql.somee.com; persist security info=False;initial catalog = babatye; MultipleActiveResultSets=True");
            var clientProvider = new SqlSyncProvider(@"Data Source= babatye.db; Version=3; FailIfMissing=True; Foreign Keys=True;");

            // Tables involved in the sync process:
            var tables = new string[] {"tbl_clothes"};

            // Creating an agent that will handle all the process
            var agent = new SyncAgent(clientProvider, serverProvider, tables);

            do
            {
                try
                {
                    // Launch the sync process
                    var s1 = await agent.SynchronizeAsync();

                    // Write results
                    Console.WriteLine(s1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(@"End");
        }

        private void HideTextBoxes()
        {
            TxtColor.Visible = false;
            TxtSize.Visible = false;
            TxtName.Visible = false;
            BtnAddNewItem.Visible = false;
            BtnAddNewItem.Enabled = false;
            BtnInsert.Enabled = true;
            //PBInsert.Visible = true;
            //PBAddNewItem.Visible = false;
        }

        private void DisplayTextBoxes()
        {
            TxtColor.Visible = true;
            TxtSize.Visible = true;
            TxtName.Visible = true;
            //PBAddNewItem.Visible = true;

            if (TxtColor.Text.Trim() != "")
                TxtColor.Enabled = false;

            if (TxtSize.Text.Trim() != "")
                TxtSize.Enabled = false;

            BtnAddNewItem.Visible = true;
            BtnAddNewItem.Enabled = true;
            BtnInsert.Enabled = false;
            //PBInsert.Visible = false;
        }

        private void BtnAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void AddNewItem()
        {
            if (!string.IsNullOrEmpty(TxtSKUNum.Text.Trim()))
            {
                _cloth.SKUNumber = TxtSKUNum.Text.Trim();
                if (!string.IsNullOrEmpty(TxtColor.Text.Trim()))
                {
                    _cloth.Color = TxtColor.Text.Trim();
                    if (!string.IsNullOrEmpty(TxtSize.Text.Trim()))
                    {
                        _cloth.Size = TxtSize.Text.Trim();
                        if (!string.IsNullOrEmpty(TxtName.Text.Trim()))
                        {
                            _cloth.Name = TxtName.Text.Trim();
                            var result = _dal.AddNewCloth(_cloth);
                            if (result > 0)
                            {
                                MessageBox.Show(@"New Item Added Successfully");
                                LoadDgv();
                                HideTextBoxes();
                            }
                            else
                            {
                                MessageBox.Show(@"Something went Wrong");
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"Product Name cannot be empty");
                            TxtName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Size cannot be empty");
                        TxtSize.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(@"Color cannot be empty");
                    TxtColor.Focus();
                }
            }
            else
            {
                MessageBox.Show(@"SKU Number cannot be empty");
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
            if (string.IsNullOrEmpty(TxtSKUNum.Text)) return;
            _cloth.SKUNumber = TxtSKUNum.Text.Trim();
            label1.Text = _cloth.ProductColor();
            label2.Text = _cloth.ProductSize();
            label3.Text = _cloth.ProductName();
        }

        private void PBInsert_Click(object sender, EventArgs e)
        {
            InsertProduct();
        }

        private void PBAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private static void OpenKeywordsFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (sender is OpenFileDialog fileDialog)
            {
                var selectedFile = fileDialog.FileName;
                if (!string.IsNullOrEmpty(selectedFile) && !selectedFile.Contains(".lnk")) return;
            }

            MessageBox.Show(@"Please select a valid Excel File");
            e.Cancel = true;
            return;
        }

        private void BtnReadFromExcel_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Multiselect = false,
                ValidateNames = true,
                DereferenceLinks = false, // Will return .lnk in shortcuts.
                //Filter = @" Excel Files(.xls)|*.xls| Excel Files(.xlsx) | *.xlsx | Excel Files(*.xlsm) | *.xlsm | CSV Files(*.csv) | *.csv"
            };
            ofd.FileOk += new System.ComponentModel.CancelEventHandler(OpenKeywordsFileDialog_FileOk);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _filePath = ofd.FileName;
                LblMessage.Text = @"Importing excel file...";
            }
            _totalRows = 0;
            var xlApp = new Excel.Application();
            if (_filePath == "") return;
            var totalRows = 0;
            var xlWorkBook = xlApp.Workbooks.Open(_filePath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            var xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Item[1];
            totalRows = xlWorkSheet.UsedRange.Rows.Count;
            PBLoading.Visible = true;
            PBLoading.Maximum = totalRows; // your loop max no.
            PBLoading.Minimum = 0;
            Excel.Range range = xlWorkSheet.UsedRange.Columns[1];
            var rw = range.Rows.Count;
            var cl = 1;
            int rCnt;
            for (rCnt = 2; rCnt <= rw; rCnt++)
            {
                int cCnt;
                for (cCnt = 1; cCnt <= cl; cCnt++)
                {
                    _totalRows++;
                    PBLoading.Value = _totalRows;
                }
            }
            LoadDgv();
            xlWorkBook.Close(true, null, null);
            xlApp.Quit();
            timer1.Enabled = true;
            LblMessage.ForeColor = Color.Green;
            LblMessage.Text = _totalRows + @" Rows Imported Successfully!";
            BtnLoad.Enabled = true;
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            TotalProducts = 0;
            var xlApp = new Excel.Application();
            if (_filePath != "")
            {
                var xlWorkBook = xlApp.Workbooks.Open(_filePath, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                var xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Item[1];
                Excel.Range range = xlWorkSheet.UsedRange.Columns[1];
                var rw = range.Rows.Count;
                var cl = 1;
                int rCnt;
                for (rCnt = 2; rCnt <= rw; rCnt++)
                {
                    int cCnt;
                    for (cCnt = 1; cCnt <= cl; cCnt++)
                    {
                        var str = (string)(range.Cells[rCnt, cCnt] as Excel.Range)?.Value2;
                        if (string.IsNullOrEmpty(str)) continue;
                        TxtSKUNum.Text = str;
                        _cloth.SKUNumber = TxtSKUNum.Text.Trim();
                        var result = _dal.InsertCloth(_cloth);
                        if (result == 0)
                        {
                            DialogResult dialogResult = MessageBox.Show(@"This item does not exist, would you like add it?", @"Item Not Exist!", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                _cloth.SKUNumber = TxtSKUNum.Text.Trim();
                                TxtColor.Text = _cloth.ProductColor();
                                TxtSize.Text = _cloth.ProductSize();
                                NewProductColor = TxtColor.Text.Trim();
                                NewProductSize = TxtSize.Text.Trim();
                                NewProductName = TxtName.Text.Trim();
                                NewSkuNumber = TxtSKUNum.Text.Trim();
                                AddProduct Ap = new AddProduct();
                                Ap.ShowDialog();
                            }
                        }
                        TotalProducts += result;
                        LblAddedItems.Text = TotalProducts.ToString();
                        PanelAddedItems.Visible = true;
                        LoadDgv();
                    }
                }

                LoadDgv();
                xlWorkBook.Close(true, null, null);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
                var dr = MessageBox.Show(TotalProducts.ToString() + @" Products Added Successfully!, would you like to delete excel source file?", @"Confirmation to remove the source file!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    FileSystem.DeleteFile(_filePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin, UICancelOption.ThrowException);
                BtnLoad.Enabled = false;
                PanelAddedItems.Visible = false;
                const string clientDb = "Data Source= babatye.db; Version=3; FailIfMissing=True; Foreign Keys=True;";
                const string serverDb = "workstation id = babatye.mssql.somee.com; packet size = 4096; user id = babatye_SQLLogin_1; pwd=2jdfhb4nco;data source = babatye.mssql.somee.com; persist security info=False;initial catalog = babatye; MultipleActiveResultSets=True";
                //Begin SyNc Process
                var serverProvider = new SqlSyncProvider(clientDb);
                var clientProvider = new SqlSyncProvider(serverDb);

                // Tables involved in the sync process:
                var tables = new string[] { "tbl_clothes" };

                // Creating an agent that will handle all the process
                var agent = new SyncAgent(clientProvider, serverProvider, tables);

                try
                {
                    // Launch the sync process
                    var s1 = agent.SynchronizeAsync();

                    // Write results
                    MessageBox.Show(@"Successfully Synced");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(@"File Name Not Selected");
            }
        }

        private void TxtFilterBySKU_KeyUp(object sender, KeyEventArgs e)
        {
            ((DataTable) DGVExistingItems.DataSource).DefaultView.RowFilter = string.Format(
                @"SKU LIKE '%{0}%' OR NAME LIKE '%{0}%' OR Size LIKE '%{0}%' OR Color LIKE '%{0}%'", TxtFilterBySKU.Text);
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                InsertProduct();
                //this is a new comment 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblMessage.Text = "";
            PBLoading.Visible = false;
            LblMessage.ForeColor = Color.FromArgb(255, 0, 0);
            timer2.Enabled = false ;
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (LblMessage.Text == "")
            {
                LblMessage.Text = _totalRows.ToString() + @" Rows Imported Successfully!";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainBorder_Click(object sender, EventArgs e)
        {

        }
    }
}
