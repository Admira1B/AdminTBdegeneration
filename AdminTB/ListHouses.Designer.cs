namespace AdminTB
{
    partial class ListHouses
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
            this.DataGridHouses = new System.Windows.Forms.DataGridView();
            this.NumberHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridHouses
            // 
            this.DataGridHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridHouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberHouse,
            this.TypeHouse,
            this.Description});
            this.DataGridHouses.Location = new System.Drawing.Point(0, 0);
            this.DataGridHouses.Name = "DataGridHouses";
            this.DataGridHouses.RowHeadersWidth = 51;
            this.DataGridHouses.RowTemplate.Height = 24;
            this.DataGridHouses.Size = new System.Drawing.Size(800, 407);
            this.DataGridHouses.TabIndex = 3;
            // 
            // NumberHouse
            // 
            this.NumberHouse.HeaderText = "№";
            this.NumberHouse.MinimumWidth = 6;
            this.NumberHouse.Name = "NumberHouse";
            this.NumberHouse.Width = 125;
            // 
            // TypeHouse
            // 
            this.TypeHouse.HeaderText = "Тип";
            this.TypeHouse.MinimumWidth = 6;
            this.TypeHouse.Name = "TypeHouse";
            this.TypeHouse.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // ListHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridHouses);
            this.Name = "ListHouses";
            this.Size = new System.Drawing.Size(800, 407);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHouses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridHouses;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}
