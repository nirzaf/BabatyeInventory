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
            this.DGVExistingItems = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.TxtFilterBySKU = new System.Windows.Forms.TextBox();
            this.LblAddedItems = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PanelAddedItems = new System.Windows.Forms.Panel();
            this.PBLoading = new System.Windows.Forms.ProgressBar();
            this.LblMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnReadFromExcel = new System.Windows.Forms.Button();
            this.PBAddNewItem = new System.Windows.Forms.PictureBox();
            this.PBInsert = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExistingItems)).BeginInit();
            this.PanelAddedItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAddNewItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSKUNum
            // 
            this.TxtSKUNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSKUNum.Location = new System.Drawing.Point(399, 41);
            this.TxtSKUNum.Name = "TxtSKUNum";
            this.TxtSKUNum.Size = new System.Drawing.Size(290, 29);
            this.TxtSKUNum.TabIndex = 0;
            this.TxtSKUNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSKUNum_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Product Name";
            // 
            // TxtColor
            // 
            this.TxtColor.Location = new System.Drawing.Point(13, 172);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(126, 20);
            this.TxtColor.TabIndex = 9;
            // 
            // TxtSize
            // 
            this.TxtSize.Location = new System.Drawing.Point(168, 171);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(126, 20);
            this.TxtSize.TabIndex = 10;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(316, 171);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(135, 20);
            this.TxtName.TabIndex = 11;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // BtnAddNewItem
            // 
            this.BtnAddNewItem.Location = new System.Drawing.Point(256, 356);
            this.BtnAddNewItem.Name = "BtnAddNewItem";
            this.BtnAddNewItem.Size = new System.Drawing.Size(50, 30);
            this.BtnAddNewItem.TabIndex = 12;
            this.BtnAddNewItem.Text = "Add New Item";
            this.BtnAddNewItem.UseVisualStyleBackColor = true;
            this.BtnAddNewItem.Click += new System.EventHandler(this.BtnAddNewItem_Click);
            // 
            // DGVExistingItems
            // 
            this.DGVExistingItems.AllowUserToAddRows = false;
            this.DGVExistingItems.AllowUserToDeleteRows = false;
            this.DGVExistingItems.AllowUserToResizeRows = false;
            this.DGVExistingItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVExistingItems.BackgroundColor = System.Drawing.Color.White;
            this.DGVExistingItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVExistingItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DGVExistingItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVExistingItems.GridColor = System.Drawing.Color.White;
            this.DGVExistingItems.Location = new System.Drawing.Point(12, 285);
            this.DGVExistingItems.Name = "DGVExistingItems";
            this.DGVExistingItems.ReadOnly = true;
            this.DGVExistingItems.RowHeadersWidth = 50;
            this.DGVExistingItems.Size = new System.Drawing.Size(477, 228);
            this.DGVExistingItems.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Enter the SKU Number ";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(256, 392);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(50, 32);
            this.BtnInsert.TabIndex = 1;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // TxtFilterBySKU
            // 
            this.TxtFilterBySKU.Location = new System.Drawing.Point(69, 242);
            this.TxtFilterBySKU.Name = "TxtFilterBySKU";
            this.TxtFilterBySKU.Size = new System.Drawing.Size(155, 20);
            this.TxtFilterBySKU.TabIndex = 21;
            this.TxtFilterBySKU.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtFilterBySKU_KeyUp);
            // 
            // LblAddedItems
            // 
            this.LblAddedItems.AutoSize = true;
            this.LblAddedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddedItems.Location = new System.Drawing.Point(75, 52);
            this.LblAddedItems.Name = "LblAddedItems";
            this.LblAddedItems.Size = new System.Drawing.Size(19, 20);
            this.LblAddedItems.TabIndex = 23;
            this.LblAddedItems.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Added Items";
            // 
            // PanelAddedItems
            // 
            this.PanelAddedItems.Controls.Add(this.label10);
            this.PanelAddedItems.Controls.Add(this.LblAddedItems);
            this.PanelAddedItems.Location = new System.Drawing.Point(495, 285);
            this.PanelAddedItems.Name = "PanelAddedItems";
            this.PanelAddedItems.Size = new System.Drawing.Size(194, 82);
            this.PanelAddedItems.TabIndex = 25;
            this.PanelAddedItems.Visible = false;
            // 
            // PBLoading
            // 
            this.PBLoading.BackColor = System.Drawing.Color.White;
            this.PBLoading.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.PBLoading.ForeColor = System.Drawing.Color.Lime;
            this.PBLoading.Location = new System.Drawing.Point(-8, -9);
            this.PBLoading.Name = "PBLoading";
            this.PBLoading.Size = new System.Drawing.Size(741, 24);
            this.PBLoading.Step = 1;
            this.PBLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBLoading.TabIndex = 26;
            this.PBLoading.Visible = false;
            // 
            // LblMessage
            // 
            this.LblMessage.BackColor = System.Drawing.Color.Transparent;
            this.LblMessage.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.Red;
            this.LblMessage.Location = new System.Drawing.Point(242, 239);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(315, 40);
            this.LblMessage.TabIndex = 27;
            this.LblMessage.Text = "Message";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BabatyeInventory.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(12, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.Location = new System.Drawing.Point(495, 373);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(194, 68);
            this.BtnLoad.TabIndex = 20;
            this.BtnLoad.Text = "Start Loading";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnReadFromExcel
            // 
            this.BtnReadFromExcel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnReadFromExcel.FlatAppearance.BorderSize = 0;
            this.BtnReadFromExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReadFromExcel.Location = new System.Drawing.Point(495, 445);
            this.BtnReadFromExcel.Name = "BtnReadFromExcel";
            this.BtnReadFromExcel.Size = new System.Drawing.Size(194, 68);
            this.BtnReadFromExcel.TabIndex = 18;
            this.BtnReadFromExcel.Text = "Import From Excel File";
            this.BtnReadFromExcel.UseVisualStyleBackColor = true;
            this.BtnReadFromExcel.Click += new System.EventHandler(this.BtnReadFromExcel_Click);
            // 
            // PBAddNewItem
            // 
            this.PBAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("PBAddNewItem.Image")));
            this.PBAddNewItem.Location = new System.Drawing.Point(469, 76);
            this.PBAddNewItem.Name = "PBAddNewItem";
            this.PBAddNewItem.Size = new System.Drawing.Size(165, 162);
            this.PBAddNewItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBAddNewItem.TabIndex = 17;
            this.PBAddNewItem.TabStop = false;
            this.PBAddNewItem.Visible = false;
            this.PBAddNewItem.Click += new System.EventHandler(this.PBAddNewItem_Click);
            // 
            // PBInsert
            // 
            this.PBInsert.Image = ((System.Drawing.Image)(resources.GetObject("PBInsert.Image")));
            this.PBInsert.Location = new System.Drawing.Point(469, 76);
            this.PBInsert.Name = "PBInsert";
            this.PBInsert.Size = new System.Drawing.Size(165, 162);
            this.PBInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBInsert.TabIndex = 16;
            this.PBInsert.TabStop = false;
            this.PBInsert.Click += new System.EventHandler(this.PBInsert_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BabatyeInventory.Properties.Resources.logo_new_300x96;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 521);
            this.Controls.Add(this.TxtFilterBySKU);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.PanelAddedItems);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnReadFromExcel);
            this.Controls.Add(this.DGVExistingItems);
            this.Controls.Add(this.PBAddNewItem);
            this.Controls.Add(this.PBInsert);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Babatye Inventory Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVExistingItems)).EndInit();
            this.PanelAddedItems.ResumeLayout(false);
            this.PanelAddedItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAddNewItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBInsert)).EndInit();
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
        public System.Windows.Forms.TextBox TxtColor;
        public System.Windows.Forms.TextBox TxtSize;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnAddNewItem;
        private System.Windows.Forms.DataGridView DGVExistingItems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PBInsert;
        private System.Windows.Forms.PictureBox PBAddNewItem;
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
    }
}

