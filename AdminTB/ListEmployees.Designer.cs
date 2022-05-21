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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVacationers)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridVacationers
            // 
            this.DataGridVacationers.AllowUserToAddRows = false;
            this.DataGridVacationers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridVacationers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVacationers.Location = new System.Drawing.Point(0, 0);
            this.DataGridVacationers.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridVacationers.Name = "DataGridVacationers";
            this.DataGridVacationers.RowHeadersWidth = 51;
            this.DataGridVacationers.RowTemplate.Height = 24;
            this.DataGridVacationers.Size = new System.Drawing.Size(600, 331);
            this.DataGridVacationers.TabIndex = 3;
            // 
            // ListEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridVacationers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListEmployees";
            this.Size = new System.Drawing.Size(600, 331);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVacationers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridVacationers;
    }
}
