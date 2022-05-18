namespace AdminTB
{
    partial class ListEmployees
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
            this.IDEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVacationers)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridVacationers
            // 
            this.DataGridVacationers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVacationers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEmployee,
            this.Surname,
            this.FirstName,
            this.Telephone,
            this.EMail});
            this.DataGridVacationers.Location = new System.Drawing.Point(0, 0);
            this.DataGridVacationers.Name = "DataGridVacationers";
            this.DataGridVacationers.RowHeadersWidth = 51;
            this.DataGridVacationers.RowTemplate.Height = 24;
            this.DataGridVacationers.Size = new System.Drawing.Size(800, 407);
            this.DataGridVacationers.TabIndex = 3;
            // 
            // IDEmployee
            // 
            this.IDEmployee.HeaderText = "ID";
            this.IDEmployee.MinimumWidth = 6;
            this.IDEmployee.Name = "IDEmployee";
            this.IDEmployee.Width = 125;
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
            // EMail
            // 
            this.EMail.HeaderText = "E-Mail";
            this.EMail.MinimumWidth = 6;
            this.EMail.Name = "EMail";
            this.EMail.Width = 125;
            // 
            // ListEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridVacationers);
            this.Name = "ListEmployees";
            this.Size = new System.Drawing.Size(800, 407);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVacationers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridVacationers;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
    }
}
