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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.договораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отдыхающиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгаЖалобToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.домаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экскурсииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительныеУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CloseButtonLinkLabel = new System.Windows.Forms.LinkLabel();
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
            this.MainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(600, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // договораToolStripMenuItem
            // 
            this.договораToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem,
            this.оформитьToolStripMenuItem});
            this.договораToolStripMenuItem.Name = "договораToolStripMenuItem";
            this.договораToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.договораToolStripMenuItem.Text = "Договора";
            // 
            // списокToolStripMenuItem
            // 
            this.списокToolStripMenuItem.Name = "списокToolStripMenuItem";
            this.списокToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.списокToolStripMenuItem.Text = "Список";
            this.списокToolStripMenuItem.Click += new System.EventHandler(this.списокToolStripMenuItem_Click);
            // 
            // оформитьToolStripMenuItem
            // 
            this.оформитьToolStripMenuItem.Name = "оформитьToolStripMenuItem";
            this.оформитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.оформитьToolStripMenuItem.Text = "Оформить";
            this.оформитьToolStripMenuItem.Click += new System.EventHandler(this.оформитьToolStripMenuItem_Click);
            // 
            // отдыхающиеToolStripMenuItem
            // 
            this.отдыхающиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокToolStripMenuItem1,
            this.добавитьToolStripMenuItem,
            this.книгаЖалобToolStripMenuItem});
            this.отдыхающиеToolStripMenuItem.Name = "отдыхающиеToolStripMenuItem";
            this.отдыхающиеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.отдыхающиеToolStripMenuItem.Text = "Отдыхающие";
            // 
            // списокToolStripMenuItem1
            // 
            this.списокToolStripMenuItem1.Name = "списокToolStripMenuItem1";
            this.списокToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.списокToolStripMenuItem1.Text = "Список";
            this.списокToolStripMenuItem1.Click += new System.EventHandler(this.списокToolStripMenuItem1_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // книгаЖалобToolStripMenuItem
            // 
            this.книгаЖалобToolStripMenuItem.Name = "книгаЖалобToolStripMenuItem";
            this.книгаЖалобToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.книгаЖалобToolStripMenuItem.Text = "Книга жалоб";
            this.книгаЖалобToolStripMenuItem.Click += new System.EventHandler(this.книгаЖалобToolStripMenuItem_Click);
            // 
            // домаToolStripMenuItem
            // 
            this.домаToolStripMenuItem.Name = "домаToolStripMenuItem";
            this.домаToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.домаToolStripMenuItem.Text = "Дома";
            this.домаToolStripMenuItem.Click += new System.EventHandler(this.домаToolStripMenuItem_Click);
            // 
            // экскурсииToolStripMenuItem
            // 
            this.экскурсииToolStripMenuItem.Name = "экскурсииToolStripMenuItem";
            this.экскурсииToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.экскурсииToolStripMenuItem.Text = "Экскурсии";
            this.экскурсииToolStripMenuItem.Click += new System.EventHandler(this.экскурсииToolStripMenuItem_Click);
            // 
            // дополнительныеУслугиToolStripMenuItem
            // 
            this.дополнительныеУслугиToolStripMenuItem.Name = "дополнительныеУслугиToolStripMenuItem";
            this.дополнительныеУслугиToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.дополнительныеУслугиToolStripMenuItem.Text = "Дополнительные услуги";
            this.дополнительныеУслугиToolStripMenuItem.Click += new System.EventHandler(this.дополнительныеУслугиToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 25);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(600, 331);
            this.MainPanel.TabIndex = 2;
            // 
            // CloseButtonLinkLabel
            // 
            this.CloseButtonLinkLabel.AutoSize = true;
            this.CloseButtonLinkLabel.BackColor = System.Drawing.Color.White;
            this.CloseButtonLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButtonLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.CloseButtonLinkLabel.Location = new System.Drawing.Point(574, 0);
            this.CloseButtonLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CloseButtonLinkLabel.Name = "CloseButtonLinkLabel";
            this.CloseButtonLinkLabel.Size = new System.Drawing.Size(25, 24);
            this.CloseButtonLinkLabel.TabIndex = 18;
            this.CloseButtonLinkLabel.TabStop = true;
            this.CloseButtonLinkLabel.Text = "X";
            this.CloseButtonLinkLabel.VisitedLinkColor = System.Drawing.Color.Red;
            this.CloseButtonLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CloseButtonLinkLabel_LinkClicked);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.CloseButtonLinkLabel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.Text = "AdminTB";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseMove);
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
        private System.Windows.Forms.LinkLabel CloseButtonLinkLabel;
        private System.Windows.Forms.ToolStripMenuItem книгаЖалобToolStripMenuItem;
    }
}