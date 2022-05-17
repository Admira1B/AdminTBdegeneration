namespace AdminTB
{
    partial class ListContarcts
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumberContracts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDVacationer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Results = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberContracts,
            this.IDVacationer,
            this.IDHouse,
            this.Term,
            this.PaymentMethod,
            this.Results});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 407);
            this.dataGridView1.TabIndex = 1;
            // 
            // NumberContracts
            // 
            this.NumberContracts.HeaderText = "№";
            this.NumberContracts.MinimumWidth = 6;
            this.NumberContracts.Name = "NumberContracts";
            this.NumberContracts.Width = 125;
            // 
            // IDVacationer
            // 
            this.IDVacationer.HeaderText = "ID";
            this.IDVacationer.MinimumWidth = 6;
            this.IDVacationer.Name = "IDVacationer";
            this.IDVacationer.Width = 125;
            // 
            // IDHouse
            // 
            this.IDHouse.HeaderText = "ID Дома";
            this.IDHouse.MinimumWidth = 6;
            this.IDHouse.Name = "IDHouse";
            this.IDHouse.Width = 125;
            // 
            // Term
            // 
            this.Term.HeaderText = "Срок проживания";
            this.Term.MinimumWidth = 6;
            this.Term.Name = "Term";
            this.Term.Width = 125;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.HeaderText = "Способ оплаты";
            this.PaymentMethod.MinimumWidth = 6;
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Width = 125;
            // 
            // Results
            // 
            this.Results.HeaderText = "Итог";
            this.Results.MinimumWidth = 6;
            this.Results.Name = "Results";
            this.Results.Width = 125;
            // 
            // ListContarcts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListContarcts";
            this.Size = new System.Drawing.Size(800, 407);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberContracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVacationer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Term;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Results;
    }
}
