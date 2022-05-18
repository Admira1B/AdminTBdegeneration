namespace AdminTB
{
    partial class ListServices
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
            this.CodeServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeServices,
            this.NameServices,
            this.DescriptionServices,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // CodeServices
            // 
            this.CodeServices.HeaderText = "Код";
            this.CodeServices.MinimumWidth = 6;
            this.CodeServices.Name = "CodeServices";
            this.CodeServices.Width = 125;
            // 
            // NameServices
            // 
            this.NameServices.HeaderText = "Название";
            this.NameServices.MinimumWidth = 6;
            this.NameServices.Name = "NameServices";
            this.NameServices.Width = 125;
            // 
            // DescriptionServices
            // 
            this.DescriptionServices.HeaderText = "Описание";
            this.DescriptionServices.MinimumWidth = 6;
            this.DescriptionServices.Name = "DescriptionServices";
            this.DescriptionServices.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Стоимость";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // ListServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListServices";
            this.Size = new System.Drawing.Size(800, 407);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
