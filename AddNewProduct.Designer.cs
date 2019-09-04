namespace BabatyeInventory
{
    partial class AddNewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewProduct));
            this.TxtNewColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNewSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNewName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNewColor
            // 
            this.TxtNewColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNewColor.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtNewColor.Location = new System.Drawing.Point(13, 34);
            this.TxtNewColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNewColor.Name = "TxtNewColor";
            this.TxtNewColor.Size = new System.Drawing.Size(230, 26);
            this.TxtNewColor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // TxtNewSize
            // 
            this.TxtNewSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNewSize.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtNewSize.Location = new System.Drawing.Point(13, 92);
            this.TxtNewSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNewSize.Name = "TxtNewSize";
            this.TxtNewSize.Size = new System.Drawing.Size(230, 26);
            this.TxtNewSize.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // TxtNewName
            // 
            this.TxtNewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNewName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtNewName.Location = new System.Drawing.Point(13, 149);
            this.TxtNewName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNewName.Name = "TxtNewName";
            this.TxtNewName.Size = new System.Drawing.Size(230, 26);
            this.TxtNewName.TabIndex = 4;
            this.TxtNewName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(11, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add New Item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewProduct
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(256, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNewName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNewSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNewColor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product Form";
            this.Load += new System.EventHandler(this.AddNewProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNewName;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TxtNewColor;
        public System.Windows.Forms.TextBox TxtNewSize;
    }
}