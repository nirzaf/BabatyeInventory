namespace BabatyeInventory
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtColor1 = new System.Windows.Forms.TextBox();
            this.TxtSize1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color";
            // 
            // TxtColor1
            // 
            this.TxtColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtColor1.Location = new System.Drawing.Point(13, 33);
            this.TxtColor1.Name = "TxtColor1";
            this.TxtColor1.Size = new System.Drawing.Size(206, 26);
            this.TxtColor1.TabIndex = 1;
            this.TxtColor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtColor1_KeyPress);
            // 
            // TxtSize1
            // 
            this.TxtSize1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSize1.Location = new System.Drawing.Point(13, 95);
            this.TxtSize1.Name = "TxtSize1";
            this.TxtSize1.Size = new System.Drawing.Size(206, 26);
            this.TxtSize1.TabIndex = 3;
            this.TxtSize1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSize1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // TxtName1
            // 
            this.TxtName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName1.Location = new System.Drawing.Point(13, 159);
            this.TxtName1.Name = "TxtName1";
            this.TxtName1.Size = new System.Drawing.Size(206, 26);
            this.TxtName1.TabIndex = 5;
            this.TxtName1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Name";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundImage = global::BabatyeInventory.Properties.Resources.white;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(10, 204);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(206, 63);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(228, 279);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtName1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSize1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtColor1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtColor1;
        private System.Windows.Forms.TextBox TxtSize1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAdd;
    }
}