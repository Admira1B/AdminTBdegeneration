namespace AdminTB
{
    partial class ListVacationers
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
            this.DataGridVacationers = new System.Windows.Forms.DataGridView();
            this.IDVacationer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVacationers)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridVacationers
            // 
            this.DataGridVacationers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVacationers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVacationer,
            this.Surname,
            this.FirstName,
            this.Telephone,
            this.PassportSeries,
            this.PassportNumber});
            this.DataGridVacationers.Location = new System.Drawing.Point(0, 0);
            this.DataGridVacationers.Name = "DataGridVacationers";
            this.DataGridVacationers.RowHeadersWidth = 51;
            this.DataGridVacationers.RowTemplate.Height = 24;
            this.DataGridVacationers.Size = new System.Drawing.Size(800, 407);
            this.DataGridVacationers.TabIndex = 2;
            // 
            // IDVacationer
            // 
            this.IDVacationer.HeaderText = "ID";
            this.IDVacationer.MinimumWidth = 6;
            this.IDVacationer.Name = "IDVacationer";
            this.IDVacationer.Width = 125;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Телефон";
            this.Telephone.MinimumWidth = 6;
            this.Telephone.Name = "Telephone";
            this.Telephone.Width = 125;
            // 
            // PassportSeries
            // 
            this.PassportSeries.HeaderText = "Серия";
            this.PassportSeries.MinimumWidth = 6;
            this.PassportSeries.Name = "PassportSeries";
            this.PassportSeries.Width = 125;
            // 
            // PassportNumber
            // 
            this.PassportNumber.HeaderText = "Номер";
            this.PassportNumber.MinimumWidth = 6;
            this.PassportNumber.Name = "PassportNumber";
            this.PassportNumber.Width = 125;
            // 
            // ListVacationers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridVacationers);
            this.Name = "ListVacationers";
            this.Size = new System.Drawing.Size(800, 407);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVacationers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridVacationers;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVacationer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportNumber;
    }
}
