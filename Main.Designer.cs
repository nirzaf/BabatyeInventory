namespace BabatyeInventory
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TxtSKUNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtColor = new System.Windows.Forms.TextBox();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnAddNewItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.TxtFilterBySKU = new System.Windows.Forms.TextBox();
            this.LblAddedItems = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PanelAddedItems = new System.Windows.Forms.Panel();
            this.PBLoading = new System.Windows.Forms.ProgressBar();
            this.LblMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnReadFromExcel = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.MainBorder = new System.Windows.Forms.Button();
            this.DGVExistingItems = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelAddedItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExistingItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSKUNum
            // 
            this.TxtSKUNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.TxtSKUNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSKUNum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSKUNum.ForeColor = System.Drawing.Color.Lime;
            this.TxtSKUNum.Location = new System.Drawing.Point(638, 140);
            this.TxtSKUNum.Name = "TxtSKUNum";
            this.TxtSKUNum.Size = new System.Drawing.Size(290, 27);
            this.TxtSKUNum.TabIndex = 0;
            this.TxtSKUNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSKUNum_KeyPress_1);
            this.TxtSKUNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSKUNum_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(340, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(544, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(122, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(325, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(531, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Product Name";
            // 
            // TxtColor
            // 
            this.TxtColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.TxtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtColor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColor.ForeColor = System.Drawing.Color.Lime;
            this.TxtColor.Location = new System.Drawing.Point(126, 291);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(126, 27);
            this.TxtColor.TabIndex = 9;
            // 
            // TxtSize
            // 
            this.TxtSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.TxtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSize.ForeColor = System.Drawing.Color.Lime;
            this.TxtSize.Location = new System.Drawing.Point(329, 290);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(126, 27);
            this.TxtSize.TabIndex = 10;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.Lime;
            this.TxtName.Location = new System.Drawing.Point(535, 290);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(260, 27);
            this.TxtName.TabIndex = 11;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // BtnAddNewItem
            // 
            this.BtnAddNewItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnAddNewItem.FlatAppearance.BorderSize = 0;
            this.BtnAddNewItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnAddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNewItem.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.BtnAddNewItem.ForeColor = System.Drawing.Color.White;
            this.BtnAddNewItem.Location = new System.Drawing.Point(944, 173);
            this.BtnAddNewItem.Name = "BtnAddNewItem";
            this.BtnAddNewItem.Size = new System.Drawing.Size(197, 27);
            this.BtnAddNewItem.TabIndex = 12;
            this.BtnAddNewItem.Text = "Add New Item";
            this.BtnAddNewItem.UseVisualStyleBackColor = false;
            this.BtnAddNewItem.Click += new System.EventHandler(this.BtnAddNewItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(634, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Enter the SKU Number ";
            // 
            // BtnInsert
            // 
            this.BtnInsert.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnInsert.FlatAppearance.BorderSize = 0;
            this.BtnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.BtnInsert.ForeColor = System.Drawing.Color.White;
            this.BtnInsert.Location = new System.Drawing.Point(944, 140);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(197, 27);
            this.BtnInsert.TabIndex = 1;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = false;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // TxtFilterBySKU
            // 
            this.TxtFilterBySKU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.TxtFilterBySKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFilterBySKU.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFilterBySKU.ForeColor = System.Drawing.Color.Lime;
            this.TxtFilterBySKU.Location = new System.Drawing.Point(163, 381);
            this.TxtFilterBySKU.Name = "TxtFilterBySKU";
            this.TxtFilterBySKU.Size = new System.Drawing.Size(244, 27);
            this.TxtFilterBySKU.TabIndex = 21;
            this.TxtFilterBySKU.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFilterBySKU_KeyUp);
            // 
            // LblAddedItems
            // 
            this.LblAddedItems.AutoSize = true;
            this.LblAddedItems.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddedItems.ForeColor = System.Drawing.Color.Black;
            this.LblAddedItems.Location = new System.Drawing.Point(95, 48);
            this.LblAddedItems.Name = "LblAddedItems";
            this.LblAddedItems.Size = new System.Drawing.Size(17, 20);
            this.LblAddedItems.TabIndex = 23;
            this.LblAddedItems.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(56, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Added Items";
            // 
            // PanelAddedItems
            // 
            this.PanelAddedItems.BackColor = System.Drawing.Color.Transparent;
            this.PanelAddedItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAddedItems.Controls.Add(this.label10);
            this.PanelAddedItems.Controls.Add(this.LblAddedItems);
            this.PanelAddedItems.ForeColor = System.Drawing.Color.White;
            this.PanelAddedItems.Location = new System.Drawing.Point(934, 438);
            this.PanelAddedItems.Name = "PanelAddedItems";
            this.PanelAddedItems.Size = new System.Drawing.Size(215, 82);
            this.PanelAddedItems.TabIndex = 25;
            this.PanelAddedItems.Visible = false;
            // 
            // PBLoading
            // 
            this.PBLoading.BackColor = System.Drawing.Color.White;
            this.PBLoading.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.PBLoading.ForeColor = System.Drawing.Color.Lime;
            this.PBLoading.Location = new System.Drawing.Point(125, 48);
            this.PBLoading.Name = "PBLoading";
            this.PBLoading.Size = new System.Drawing.Size(803, 24);
            this.PBLoading.Step = 1;
            this.PBLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBLoading.TabIndex = 26;
            this.PBLoading.Visible = false;
            // 
            // LblMessage
            // 
            this.LblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.LblMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.Red;
            this.LblMessage.Location = new System.Drawing.Point(429, 383);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(499, 43);
            this.LblMessage.TabIndex = 27;
            this.LblMessage.Text = "Message";
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnLoad
            // 
            this.BtnLoad.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnLoad.FlatAppearance.BorderSize = 0;
            this.BtnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.ForeColor = System.Drawing.Color.White;
            this.BtnLoad.Location = new System.Drawing.Point(934, 526);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(215, 68);
            this.BtnLoad.TabIndex = 20;
            this.BtnLoad.Text = "Start Loading";
            this.BtnLoad.UseVisualStyleBackColor = false;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnReadFromExcel
            // 
            this.BtnReadFromExcel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnReadFromExcel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnReadFromExcel.FlatAppearance.BorderSize = 0;
            this.BtnReadFromExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnReadFromExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReadFromExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReadFromExcel.ForeColor = System.Drawing.Color.White;
            this.BtnReadFromExcel.Location = new System.Drawing.Point(934, 598);
            this.BtnReadFromExcel.Name = "BtnReadFromExcel";
            this.BtnReadFromExcel.Size = new System.Drawing.Size(215, 68);
            this.BtnReadFromExcel.TabIndex = 18;
            this.BtnReadFromExcel.Text = "Import From Excel File";
            this.BtnReadFromExcel.UseVisualStyleBackColor = false;
            this.BtnReadFromExcel.Click += new System.EventHandler(this.BtnReadFromExcel_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainBorder
            // 
            this.MainBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.MainBorder.Enabled = false;
            this.MainBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.MainBorder.Location = new System.Drawing.Point(0, 0);
            this.MainBorder.Name = "MainBorder";
            this.MainBorder.Size = new System.Drawing.Size(1280, 719);
            this.MainBorder.TabIndex = 99;
            this.MainBorder.UseVisualStyleBackColor = false;
            this.MainBorder.Click += new System.EventHandler(this.MainBorder_Click);
            // 
            // DGVExistingItems
            // 
            this.DGVExistingItems.AllowUserToAddRows = false;
            this.DGVExistingItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVExistingItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVExistingItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.DGVExistingItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVExistingItems.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVExistingItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVExistingItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVExistingItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(79)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVExistingItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVExistingItems.EnableHeadersVisualStyles = false;
            this.DGVExistingItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.DGVExistingItems.Location = new System.Drawing.Point(125, 438);
            this.DGVExistingItems.MultiSelect = false;
            this.DGVExistingItems.Name = "DGVExistingItems";
            this.DGVExistingItems.ReadOnly = true;
            this.DGVExistingItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVExistingItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVExistingItems.RowHeadersVisible = false;
            this.DGVExistingItems.RowHeadersWidth = 55;
            this.DGVExistingItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.DGVExistingItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVExistingItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVExistingItems.Size = new System.Drawing.Size(803, 228);
            this.DGVExistingItems.TabIndex = 210;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1228, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 33);
            this.btnClose.TabIndex = 211;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.pictureBox2.Image = global::BabatyeInventory.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(106, 360);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.pictureBox1.Image = global::BabatyeInventory.Properties.Resources.logo_new_300x96;
            this.pictureBox1.Location = new System.Drawing.Point(125, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 716);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.DGVExistingItems);
            this.Controls.Add(this.TxtFilterBySKU);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.PanelAddedItems);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnReadFromExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.TxtColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSKUNum);
            this.Controls.Add(this.BtnAddNewItem);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.PBLoading);
            this.Controls.Add(this.MainBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Babatye Inventory Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PanelAddedItems.ResumeLayout(false);
            this.PanelAddedItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExistingItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtSKUNum;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnAddNewItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnReadFromExcel;
        private System.Windows.Forms.Button BtnLoad;
        public System.Windows.Forms.TextBox TxtFilterBySKU;
        private System.Windows.Forms.Label LblAddedItems;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel PanelAddedItems;
        private System.Windows.Forms.ProgressBar PBLoading;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.TextBox TxtColor;
        public System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.Button MainBorder;
        private System.Windows.Forms.DataGridView DGVExistingItems;
        private System.Windows.Forms.Button btnClose;
    }
}

