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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridHouses
            // 
            this.DataGridHouses.AllowUserToAddRows = false;
            this.DataGridHouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridHouses.Location = new System.Drawing.Point(0, 0);
            this.DataGridHouses.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridHouses.Name = "DataGridHouses";
            this.DataGridHouses.RowHeadersWidth = 51;
            this.DataGridHouses.RowTemplate.Height = 24;
            this.DataGridHouses.Size = new System.Drawing.Size(600, 331);
            this.DataGridHouses.TabIndex = 3;
            // 
            // ListHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridHouses);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListHouses";
            this.Size = new System.Drawing.Size(600, 331);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHouses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridHouses;
    }
}
