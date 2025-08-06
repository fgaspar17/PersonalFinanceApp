namespace PersonalFinanceApp.WinForms
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            categoryDataGridView = new DataGridView();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDtoBindingSource = new BindingSource(components);
            crudPanel = new Panel();
            categoryDeleteButton = new Button();
            categoryUpdateButton = new Button();
            categoryNameLabel = new Label();
            categoryNameTextBox = new TextBox();
            categoryCreateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryDtoBindingSource).BeginInit();
            crudPanel.SuspendLayout();
            SuspendLayout();
            // 
            // categoryDataGridView
            // 
            categoryDataGridView.AllowUserToAddRows = false;
            categoryDataGridView.AllowUserToDeleteRows = false;
            categoryDataGridView.AllowUserToOrderColumns = true;
            categoryDataGridView.AutoGenerateColumns = false;
            categoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { categoryIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            categoryDataGridView.DataSource = categoryDtoBindingSource;
            categoryDataGridView.Dock = DockStyle.Fill;
            categoryDataGridView.Location = new Point(0, 42);
            categoryDataGridView.Name = "categoryDataGridView";
            categoryDataGridView.ReadOnly = true;
            categoryDataGridView.Size = new Size(800, 408);
            categoryDataGridView.TabIndex = 2;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "Id";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            categoryIdDataGridViewTextBoxColumn.Visible = false;
            categoryIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Category";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoryDtoBindingSource
            // 
            categoryDtoBindingSource.DataSource = typeof(Services.DTOs.CategoryDto);
            // 
            // crudPanel
            // 
            crudPanel.Controls.Add(categoryDeleteButton);
            crudPanel.Controls.Add(categoryUpdateButton);
            crudPanel.Controls.Add(categoryNameLabel);
            crudPanel.Controls.Add(categoryNameTextBox);
            crudPanel.Controls.Add(categoryCreateButton);
            crudPanel.Dock = DockStyle.Top;
            crudPanel.Location = new Point(0, 0);
            crudPanel.Name = "crudPanel";
            crudPanel.Size = new Size(800, 42);
            crudPanel.TabIndex = 3;
            // 
            // categoryDeleteButton
            // 
            categoryDeleteButton.Location = new Point(713, 11);
            categoryDeleteButton.Name = "categoryDeleteButton";
            categoryDeleteButton.Size = new Size(75, 23);
            categoryDeleteButton.TabIndex = 4;
            categoryDeleteButton.Text = "Delete";
            categoryDeleteButton.UseVisualStyleBackColor = true;
            categoryDeleteButton.Click += categoryDeleteButton_Click;
            // 
            // categoryUpdateButton
            // 
            categoryUpdateButton.Location = new Point(551, 11);
            categoryUpdateButton.Name = "categoryUpdateButton";
            categoryUpdateButton.Size = new Size(75, 23);
            categoryUpdateButton.TabIndex = 3;
            categoryUpdateButton.Text = "Update";
            categoryUpdateButton.UseVisualStyleBackColor = true;
            categoryUpdateButton.Click += categoryUpdateButton_Click;
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new Point(12, 15);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new Size(58, 15);
            categoryNameLabel.TabIndex = 2;
            categoryNameLabel.Text = "Category:";
            // 
            // categoryNameTextBox
            // 
            categoryNameTextBox.Location = new Point(76, 12);
            categoryNameTextBox.Name = "categoryNameTextBox";
            categoryNameTextBox.Size = new Size(220, 23);
            categoryNameTextBox.TabIndex = 1;
            // 
            // categoryCreateButton
            // 
            categoryCreateButton.Location = new Point(632, 11);
            categoryCreateButton.Name = "categoryCreateButton";
            categoryCreateButton.Size = new Size(75, 23);
            categoryCreateButton.TabIndex = 0;
            categoryCreateButton.Text = "Create";
            categoryCreateButton.UseVisualStyleBackColor = true;
            categoryCreateButton.Click += categoryCreateButton_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(categoryDataGridView);
            Controls.Add(crudPanel);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryDtoBindingSource).EndInit();
            crudPanel.ResumeLayout(false);
            crudPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView categoryDataGridView;
        private Panel crudPanel;
        private Button categoryDeleteButton;
        private Button categoryUpdateButton;
        private Label categoryNameLabel;
        private TextBox categoryNameTextBox;
        private Button categoryCreateButton;
        private BindingSource categoryDtoBindingSource;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}