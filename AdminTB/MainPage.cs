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
    }
}
