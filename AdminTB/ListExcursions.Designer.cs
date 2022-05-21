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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridExcursions)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridExcursions
            // 
            this.DataGridExcursions.AllowUserToAddRows = false;
            this.DataGridExcursions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridExcursions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridExcursions.Location = new System.Drawing.Point(0, 0);
            this.DataGridExcursions.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridExcursions.Name = "DataGridExcursions";
            this.DataGridExcursions.RowHeadersWidth = 51;
            this.DataGridExcursions.RowTemplate.Height = 24;
            this.DataGridExcursions.Size = new System.Drawing.Size(600, 331);
            this.DataGridExcursions.TabIndex = 2;
            // 
            // ListExcursions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridExcursions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListExcursions";
            this.Size = new System.Drawing.Size(600, 331);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridExcursions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridExcursions;
    }
}
