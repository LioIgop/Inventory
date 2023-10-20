namespace Inventory
{
    partial class FormAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSsellPrice = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            richTextDescription = new RichTextBox();
            btnAddProduct = new Button();
            gridViewProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 132);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 171);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 209);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 5;
            label6.Text = "Qty";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 248);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 6;
            label7.Text = "Sell Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(378, 63);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 7;
            label8.Text = "Description";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(81, 60);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(188, 23);
            txtProductName.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(81, 206);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(188, 23);
            txtQuantity.TabIndex = 9;
            // 
            // txtSsellPrice
            // 
            txtSsellPrice.Location = new Point(81, 245);
            txtSsellPrice.Name = "txtSsellPrice";
            txtSsellPrice.Size = new Size(188, 23);
            txtSsellPrice.TabIndex = 10;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(81, 98);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(188, 23);
            cbCategory.TabIndex = 11;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(81, 132);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(188, 23);
            dtPickerMfgDate.TabIndex = 12;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(81, 165);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(188, 23);
            dtPickerExpDate.TabIndex = 13;
            // 
            // richTextDescription
            // 
            richTextDescription.Location = new Point(378, 81);
            richTextDescription.Name = "richTextDescription";
            richTextDescription.Size = new Size(332, 148);
            richTextDescription.TabIndex = 14;
            richTextDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.ForeColor = Color.Blue;
            btnAddProduct.Location = new Point(617, 248);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(93, 23);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(12, 287);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.RowTemplate.Height = 25;
            gridViewProductList.Size = new Size(776, 151);
            gridViewProductList.TabIndex = 16;
            // 
            // FormAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(gridViewProductList);
            Controls.Add(btnAddProduct);
            Controls.Add(richTextDescription);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtSsellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "FormAddProduct";
            Text = "Inventory";
            Load += FormAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSsellPrice;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private RichTextBox richTextDescription;
        private Button btnAddProduct;
        private DataGridView gridViewProductList;
    }
}