
namespace AdminTB
{
    partial class ListReportBook
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
            this.ReportBookDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReportBookDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportBookDataGrid
            // 
            this.ReportBookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportBookDataGrid.Location = new System.Drawing.Point(0, 0);
            this.ReportBookDataGrid.Name = "ReportBookDataGrid";
            this.ReportBookDataGrid.Size = new System.Drawing.Size(600, 331);
            this.ReportBookDataGrid.TabIndex = 0;
            // 
            // ListReportBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReportBookDataGrid);
            this.Name = "ListReportBook";
            this.Size = new System.Drawing.Size(600, 331);
            ((System.ComponentModel.ISupportInitialize)(this.ReportBookDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportBookDataGrid;
    }
}
