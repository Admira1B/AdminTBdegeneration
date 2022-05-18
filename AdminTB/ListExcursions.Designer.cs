namespace AdminTB
{
    partial class ListExcursions
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
            this.DataGridExcursions = new System.Windows.Forms.DataGridView();
            this.NumberExcursions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscriptonEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridExcursions)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridExcursions
            // 
            this.DataGridExcursions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridExcursions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberExcursions,
            this.IDEmployee,
            this.DiscriptonEx,
            this.Price,
            this.Date,
            this.Place});
            this.DataGridExcursions.Location = new System.Drawing.Point(0, 0);
            this.DataGridExcursions.Name = "DataGridExcursions";
            this.DataGridExcursions.RowHeadersWidth = 51;
            this.DataGridExcursions.RowTemplate.Height = 24;
            this.DataGridExcursions.Size = new System.Drawing.Size(800, 407);
            this.DataGridExcursions.TabIndex = 2;
            // 
            // NumberExcursions
            // 
            this.NumberExcursions.HeaderText = "№";
            this.NumberExcursions.MinimumWidth = 6;
            this.NumberExcursions.Name = "NumberExcursions";
            this.NumberExcursions.Width = 125;
            // 
            // IDEmployee
            // 
            this.IDEmployee.HeaderText = "ID";
            this.IDEmployee.MinimumWidth = 6;
            this.IDEmployee.Name = "IDEmployee";
            this.IDEmployee.Width = 125;
            // 
            // DiscriptonEx
            // 
            this.DiscriptonEx.HeaderText = "Описание";
            this.DiscriptonEx.MinimumWidth = 6;
            this.DiscriptonEx.Name = "DiscriptonEx";
            this.DiscriptonEx.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Стоимость";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Place
            // 
            this.Place.HeaderText = "Место проведения";
            this.Place.MinimumWidth = 6;
            this.Place.Name = "Place";
            this.Place.Width = 125;
            // 
            // ListExcursions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridExcursions);
            this.Name = "ListExcursions";
            this.Size = new System.Drawing.Size(800, 407);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridExcursions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridExcursions;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberExcursions;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscriptonEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
    }
}
