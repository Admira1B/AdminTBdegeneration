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
            this.DataGridContracts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridContracts
            // 
            this.DataGridContracts.AllowUserToAddRows = false;
            this.DataGridContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridContracts.Location = new System.Drawing.Point(0, 0);
            this.DataGridContracts.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridContracts.Name = "DataGridContracts";
            this.DataGridContracts.RowHeadersWidth = 51;
            this.DataGridContracts.RowTemplate.Height = 24;
            this.DataGridContracts.Size = new System.Drawing.Size(600, 331);
            this.DataGridContracts.TabIndex = 1;
            // 
            // ListContarcts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridContracts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListContarcts";
            this.Size = new System.Drawing.Size(600, 331);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridContracts;
    }
}
