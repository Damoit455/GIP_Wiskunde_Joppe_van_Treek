using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIP_Wiskunde_Joppe_van_Treek
{
    public partial class Startpage : Form
    {
        public Startpage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAflossing_Click(object sender, EventArgs e)
        {
            frmAflossingsplan fAflossing = new frmAflossingsplan();
            fAflossing.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIntrest_Click(object sender, EventArgs e)
        {
            frmIntrestberekening fIntrest = new frmIntrestberekening();
            fIntrest.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
