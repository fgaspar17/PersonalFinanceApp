namespace PersonalFinanceApp.WinForms
{
    partial class PaymentMethodForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            paymentMethodDataGridView = new DataGridView();
            paymentMethodIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentMethodDtoBindingSource = new BindingSource(components);
            crudPanel = new Panel();
            paymentMethodDeleteButton = new Button();
            paymentMethodUpdateButton = new Button();
            paymentMethodNameLabel = new Label();
            paymentMethodNameTextBox = new TextBox();
            paymentMethodCreateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)paymentMethodDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentMethodDtoBindingSource).BeginInit();
            crudPanel.SuspendLayout();
            SuspendLayout();
            // 
            // paymentMethodDataGridView
            // 
            paymentMethodDataGridView.AllowUserToAddRows = false;
            paymentMethodDataGridView.AllowUserToDeleteRows = false;
            paymentMethodDataGridView.AllowUserToOrderColumns = true;
            paymentMethodDataGridView.AutoGenerateColumns = false;
            paymentMethodDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentMethodDataGridView.Columns.AddRange(new DataGridViewColumn[] { paymentMethodIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            paymentMethodDataGridView.DataSource = paymentMethodDtoBindingSource;
            paymentMethodDataGridView.Dock = DockStyle.Fill;
            paymentMethodDataGridView.Location = new Point(0, 42);
            paymentMethodDataGridView.Name = "paymentMethodDataGridView";
            paymentMethodDataGridView.ReadOnly = true;
            paymentMethodDataGridView.Size = new Size(800, 408);
            paymentMethodDataGridView.TabIndex = 0;
            // 
            // paymentMethodIdDataGridViewTextBoxColumn
            // 
            paymentMethodIdDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethodId";
            paymentMethodIdDataGridViewTextBoxColumn.HeaderText = "Id";
            paymentMethodIdDataGridViewTextBoxColumn.Name = "paymentMethodIdDataGridViewTextBoxColumn";
            paymentMethodIdDataGridViewTextBoxColumn.ReadOnly = true;
            paymentMethodIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Payment Method";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // paymentMethodDtoBindingSource
            // 
            paymentMethodDtoBindingSource.DataSource = typeof(Services.DTOs.PaymentMethodDto);
            // 
            // crudPanel
            // 
            crudPanel.Controls.Add(paymentMethodDeleteButton);
            crudPanel.Controls.Add(paymentMethodUpdateButton);
            crudPanel.Controls.Add(paymentMethodNameLabel);
            crudPanel.Controls.Add(paymentMethodNameTextBox);
            crudPanel.Controls.Add(paymentMethodCreateButton);
            crudPanel.Dock = DockStyle.Top;
            crudPanel.Location = new Point(0, 0);
            crudPanel.Name = "crudPanel";
            crudPanel.Size = new Size(800, 42);
            crudPanel.TabIndex = 1;
            // 
            // paymentMethodDeleteButton
            // 
            paymentMethodDeleteButton.Location = new Point(713, 11);
            paymentMethodDeleteButton.Name = "paymentMethodDeleteButton";
            paymentMethodDeleteButton.Size = new Size(75, 23);
            paymentMethodDeleteButton.TabIndex = 4;
            paymentMethodDeleteButton.Text = "Delete";
            paymentMethodDeleteButton.UseVisualStyleBackColor = true;
            paymentMethodDeleteButton.Click += paymentMethodDeleteButton_Click;
            // 
            // paymentMethodUpdateButton
            // 
            paymentMethodUpdateButton.Location = new Point(551, 11);
            paymentMethodUpdateButton.Name = "paymentMethodUpdateButton";
            paymentMethodUpdateButton.Size = new Size(75, 23);
            paymentMethodUpdateButton.TabIndex = 3;
            paymentMethodUpdateButton.Text = "Update";
            paymentMethodUpdateButton.UseVisualStyleBackColor = true;
            paymentMethodUpdateButton.Click += paymentMethodUpdateButton_Click;
            // 
            // paymentMethodNameLabel
            // 
            paymentMethodNameLabel.AutoSize = true;
            paymentMethodNameLabel.Location = new Point(12, 15);
            paymentMethodNameLabel.Name = "paymentMethodNameLabel";
            paymentMethodNameLabel.Size = new Size(102, 15);
            paymentMethodNameLabel.TabIndex = 2;
            paymentMethodNameLabel.Text = "Payment Method:";
            // 
            // paymentMethodNameTextBox
            // 
            paymentMethodNameTextBox.Location = new Point(120, 12);
            paymentMethodNameTextBox.Name = "paymentMethodNameTextBox";
            paymentMethodNameTextBox.Size = new Size(220, 23);
            paymentMethodNameTextBox.TabIndex = 1;
            // 
            // paymentMethodCreateButton
            // 
            paymentMethodCreateButton.Location = new Point(632, 11);
            paymentMethodCreateButton.Name = "paymentMethodCreateButton";
            paymentMethodCreateButton.Size = new Size(75, 23);
            paymentMethodCreateButton.TabIndex = 0;
            paymentMethodCreateButton.Text = "Create";
            paymentMethodCreateButton.UseVisualStyleBackColor = true;
            paymentMethodCreateButton.Click += paymentMethodCreateButton_Click;
            // 
            // PaymentMethodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(paymentMethodDataGridView);
            Controls.Add(crudPanel);
            Name = "PaymentMethodForm";
            Text = "Payment Methods";
            Load += PaymentMethodForm_Load;
            ((System.ComponentModel.ISupportInitialize)paymentMethodDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentMethodDtoBindingSource).EndInit();
            crudPanel.ResumeLayout(false);
            crudPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView paymentMethodDataGridView;
        private BindingSource paymentMethodDtoBindingSource;
        private Panel crudPanel;
        private Label paymentMethodNameLabel;
        private TextBox paymentMethodNameTextBox;
        private Button paymentMethodCreateButton;
        private Button paymentMethodUpdateButton;
        private DataGridViewTextBoxColumn paymentMethodIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private Button paymentMethodDeleteButton;
    }
}
