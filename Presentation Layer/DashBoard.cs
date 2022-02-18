using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System.Presentation_Layer
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageFoodTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageFoodType manageFoodType = new ManageFoodType();
            manageFoodType.Show();
            this.Hide();

        }

        private void manageFoodMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageFoodMenu manageFoodMenu = new ManageFoodMenu();
            manageFoodMenu.Show();
            this.Hide();
        }
    }
}
