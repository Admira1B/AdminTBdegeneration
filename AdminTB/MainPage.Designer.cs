namespace AdminTB
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.договораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отдыхающиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.домаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экскурсииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительныеУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.договораToolStripMenuItem,
            this.отдыхающиеToolStripMenuItem,
            this.домаToolStripMenuItem,
            this.экскурсииToolStripMenuItem,
            this.дополнительныеУслугиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 28);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // договораToolStripMenuItem
            // 
            this.договораToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem,
            this.оформитьToolStripMenuItem});
            this.договораToolStripMenuItem.Name = "договораToolStripMenuItem";
            this.договораToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.договораToolStripMenuItem.Text = "Договора";
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.списокToolStripMenuItem.Text = "Список";
            this.списокToolStripMenuItem.Click += new System.EventHandler(this.списокToolStripMenuItem_Click);
            // 
            // оформитьToolStripMenuItem
            // 
            this.оформитьToolStripMenuItem.Name = "оформитьToolStripMenuItem";
            this.оформитьToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.оформитьToolStripMenuItem.Text = "Оформить";
            // 
            // отдыхающиеToolStripMenuItem
            // 
            this.отдыхающиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem1,
            this.добавитьToolStripMenuItem});
            this.отдыхающиеToolStripMenuItem.Name = "отдыхающиеToolStripMenuItem";
            this.отдыхающиеToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.отдыхающиеToolStripMenuItem.Text = "Отдыхающие";
            // 
            // списокToolStripMenuItem1
            // 
            this.списокToolStripMenuItem1.Name = "списокToolStripMenuItem1";
            this.списокToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.списокToolStripMenuItem1.Text = "Список";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // домаToolStripMenuItem
            // 
            this.домаToolStripMenuItem.Name = "домаToolStripMenuItem";
            this.домаToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.домаToolStripMenuItem.Text = "Дома";
            // 
            // экскурсииToolStripMenuItem
            // 
            this.экскурсииToolStripMenuItem.Name = "экскурсииToolStripMenuItem";
            this.экскурсииToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.экскурсииToolStripMenuItem.Text = "Экскурсии";
            // 
            // дополнительныеУслугиToolStripMenuItem
            // 
            this.дополнительныеУслугиToolStripMenuItem.Name = "дополнительныеУслугиToolStripMenuItem";
            this.дополнительныеУслугиToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.дополнительныеУслугиToolStripMenuItem.Text = "Дополнительные услуги";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 31);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 407);
            this.MainPanel.TabIndex = 2;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainMenu);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem договораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оформитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отдыхающиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem домаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экскурсииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дополнительныеУслугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
    }
}