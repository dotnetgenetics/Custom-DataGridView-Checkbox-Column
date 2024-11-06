namespace CustomDataGridViewCheckboxColumn
{
    partial class FDataGridViewCheckbox
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgData = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Discontinued = new DataGridViewCheckBoxColumn();
            Discontinue = new CustomCheckbox.DatagridviewCustomCheckboxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            datagridviewCustomCheckboxColumn1 = new CustomCheckbox.DatagridviewCustomCheckboxColumn();
            ((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
            SuspendLayout();
            // 
            // dgData
            // 
            dgData.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgData.Columns.AddRange(new DataGridViewColumn[] { Id, ProductName, Price, Discontinued, Discontinue });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgData.DefaultCellStyle = dataGridViewCellStyle2;
            dgData.Dock = DockStyle.Fill;
            dgData.Location = new Point(0, 0);
            dgData.Margin = new Padding(4, 3, 4, 3);
            dgData.Name = "dgData";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgData.RowHeadersWidth = 21;
            dgData.Size = new Size(677, 213);
            dgData.TabIndex = 1;
            // 
            // Id
            // 
            Id.DataPropertyName = "ProductID";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 80;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Name";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 220;
            // 
            // Price
            // 
            Price.DataPropertyName = "UnitPrice";
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Discontinued
            // 
            Discontinued.DataPropertyName = "Discontinued";
            Discontinued.HeaderText = "Discontinue";
            Discontinued.Name = "Discontinued";
            Discontinued.ReadOnly = true;
            Discontinued.Resizable = DataGridViewTriState.True;
            Discontinued.SortMode = DataGridViewColumnSortMode.Automatic;
            Discontinued.Width = 70;
            // 
            // Discontinue
            // 
            Discontinue.DataPropertyName = "Discontinued";
            Discontinue.HeaderText = "Discontinue";
            Discontinue.Name = "Discontinue";
            Discontinue.ReadOnly = true;
            Discontinue.Width = 70;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.DataPropertyName = "Discontinued";
            dataGridViewCheckBoxColumn1.HeaderText = "Discontinued";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.ReadOnly = true;
            dataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewCheckBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewCheckBoxColumn1.Width = 80;
            // 
            // datagridviewCustomCheckboxColumn1
            // 
            datagridviewCustomCheckboxColumn1.DataPropertyName = "Discontinued";
            datagridviewCustomCheckboxColumn1.HeaderText = "Discontinue";
            datagridviewCustomCheckboxColumn1.Name = "datagridviewCustomCheckboxColumn1";
            datagridviewCustomCheckboxColumn1.ReadOnly = true;
            // 
            // FDataGridViewCheckbox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 185);
            Controls.Add(dgData);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FDataGridViewCheckbox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datagrid Custom Checkbox Column";
            Load += FDataGridViewCheckbox_Load;
            ((System.ComponentModel.ISupportInitialize)dgData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private CustomCheckbox.DatagridviewCustomCheckboxColumn datagridviewCustomCheckboxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Discontinued;
        private CustomCheckbox.DatagridviewCustomCheckboxColumn Discontinue;
    }
}
