using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminTB
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListContarcts listcontractspanel = new ListContarcts();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(listcontractspanel);
        }

        private void списокToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListVacationers listvacationerspanel = new ListVacationers();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(listvacationerspanel);
        }

        private void домаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListHouses listhousespanel = new ListHouses();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(listhousespanel);
        }

        private void экскурсииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListExcursions listexcursionspanel = new ListExcursions();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(listexcursionspanel);
        }

        private void дополнительныеУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListServices listservicespanel = new ListServices();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(listservicespanel);
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListEmployees listemployeespanel = new ListEmployees();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(listemployeespanel);
        }

        private void CloseButtonLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void MainPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void MainPage_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
    }
}
