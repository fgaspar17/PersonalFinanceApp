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
            dataGridViewPaymentMethods = new DataGridView();
            paymentMethodIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentMethodDtoBindingSource = new BindingSource(components);
            panel1 = new Panel();
            paymentMethodUpdateButton = new Button();
            paymentMethodNameLabel = new Label();
            paymentMethodNameTextBox = new TextBox();
            paymentMethodCreateButton = new Button();
            paymentMethodDeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaymentMethods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentMethodDtoBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPaymentMethods
            // 
            dataGridViewPaymentMethods.AllowUserToAddRows = false;
            dataGridViewPaymentMethods.AllowUserToDeleteRows = false;
            dataGridViewPaymentMethods.AllowUserToOrderColumns = true;
            dataGridViewPaymentMethods.AutoGenerateColumns = false;
            dataGridViewPaymentMethods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPaymentMethods.Columns.AddRange(new DataGridViewColumn[] { paymentMethodIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridViewPaymentMethods.DataSource = paymentMethodDtoBindingSource;
            dataGridViewPaymentMethods.Dock = DockStyle.Fill;
            dataGridViewPaymentMethods.Location = new Point(0, 42);
            dataGridViewPaymentMethods.Name = "dataGridViewPaymentMethods";
            dataGridViewPaymentMethods.ReadOnly = true;
            dataGridViewPaymentMethods.Size = new Size(800, 408);
            dataGridViewPaymentMethods.TabIndex = 0;
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
            // panel1
            // 
            panel1.Controls.Add(paymentMethodDeleteButton);
            panel1.Controls.Add(paymentMethodUpdateButton);
            panel1.Controls.Add(paymentMethodNameLabel);
            panel1.Controls.Add(paymentMethodNameTextBox);
            panel1.Controls.Add(paymentMethodCreateButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 42);
            panel1.TabIndex = 1;
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
            // PaymentMethodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewPaymentMethods);
            Controls.Add(panel1);
            Name = "PaymentMethodForm";
            Text = "Payment Methods";
            Load += PaymentMethodForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaymentMethods).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentMethodDtoBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPaymentMethods;
        private BindingSource paymentMethodDtoBindingSource;
        private Panel panel1;
        private Label paymentMethodNameLabel;
        private TextBox paymentMethodNameTextBox;
        private Button paymentMethodCreateButton;
        private Button paymentMethodUpdateButton;
        private DataGridViewTextBoxColumn paymentMethodIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private Button paymentMethodDeleteButton;
    }
}
