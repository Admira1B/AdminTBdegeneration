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
            this.DataGridServices = new System.Windows.Forms.DataGridView();
            this.CodeServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscriptonServ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServices)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridServices
            // 
            this.DataGridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeServices,
            this.Name,
            this.DiscriptonServ,
            this.Price});
            this.DataGridServices.Location = new System.Drawing.Point(0, 0);
            this.DataGridServices.Name = "DataGridServices";
            this.DataGridServices.RowHeadersWidth = 51;
            this.DataGridServices.RowTemplate.Height = 24;
            this.DataGridServices.Size = new System.Drawing.Size(800, 407);
            this.DataGridServices.TabIndex = 3;
            // 
            // CodeServices
            // 
            this.CodeServices.HeaderText = "Код";
            this.CodeServices.MinimumWidth = 6;
            this.CodeServices.Name = "CodeServices";
            this.CodeServices.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Название";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // DiscriptonServ
            // 
            this.DiscriptonServ.HeaderText = "Описание";
            this.DiscriptonServ.MinimumWidth = 6;
            this.DiscriptonServ.Name = "DiscriptonServ";
            this.DiscriptonServ.Width = 125;
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
            this.Controls.Add(this.DataGridServices);
            this.Name = "ListServices";
            this.Size = new System.Drawing.Size(800, 407);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscriptonServ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
