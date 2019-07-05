namespace StockManagementSystemAPP
{
    partial class StockInUi
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
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.stockInQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.displayStockIn = new System.Windows.Forms.DataGridView();
            this.stockInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockin_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editLink = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayStockIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(295, 34);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(200, 21);
            this.companyComboBox.TabIndex = 0;
            this.companyComboBox.ValueMember = "ID";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StockManagementSystemAPP.Models.Company);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(295, 71);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(200, 21);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.ValueMember = "ID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StockManagementSystemAPP.Models.Category);
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(295, 107);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(200, 21);
            this.itemComboBox.TabIndex = 2;
            this.itemComboBox.ValueMember = "ID";
            this.itemComboBox.SelectedIndexChanged += new System.EventHandler(this.itemComboBox_SelectedIndexChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(StockManagementSystemAPP.Models.Item);
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(295, 143);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(200, 20);
            this.reorderLevelTextBox.TabIndex = 3;
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Location = new System.Drawing.Point(295, 180);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.availableQuantityTextBox.TabIndex = 4;
            // 
            // stockInQuantityTextBox
            // 
            this.stockInQuantityTextBox.Location = new System.Drawing.Point(295, 218);
            this.stockInQuantityTextBox.Name = "stockInQuantityTextBox";
            this.stockInQuantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.stockInQuantityTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Reorder Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Available Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stock In Quantity";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(420, 253);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // displayStockIn
            // 
            this.displayStockIn.AutoGenerateColumns = false;
            this.displayStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayStockIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SI,
            this.itemDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.stockin_quantity,
            this.editLink});
            this.displayStockIn.DataSource = this.stockInBindingSource;
            this.displayStockIn.Location = new System.Drawing.Point(123, 291);
            this.displayStockIn.Name = "displayStockIn";
            this.displayStockIn.Size = new System.Drawing.Size(541, 206);
            this.displayStockIn.TabIndex = 13;
            this.displayStockIn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayStockIn_CellContentClick);
            this.displayStockIn.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.displayStockIn_RowPostPaint);
            // 
            // stockInBindingSource
            // 
            this.stockInBindingSource.DataSource = typeof(StockManagementSystemAPP.Models.StockIn);
            // 
            // SI
            // 
            this.SI.HeaderText = "SI";
            this.SI.Name = "SI";
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // stockin_quantity
            // 
            this.stockin_quantity.DataPropertyName = "stockin_quantity";
            this.stockin_quantity.HeaderText = "Quantity";
            this.stockin_quantity.Name = "stockin_quantity";
            // 
            // editLink
            // 
            this.editLink.HeaderText = "Action";
            this.editLink.Name = "editLink";
            // 
            // StockInUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.displayStockIn);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockInQuantityTextBox);
            this.Controls.Add(this.availableQuantityTextBox);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(this.itemComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.companyComboBox);
            this.Name = "StockInUi";
            this.Text = "Stock In";
            this.Load += new System.EventHandler(this.StockInUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayStockIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.TextBox stockInQuantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView displayStockIn;
        private System.Windows.Forms.BindingSource stockInBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SI;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockin_quantity;
        private System.Windows.Forms.DataGridViewLinkColumn editLink;
    }
}