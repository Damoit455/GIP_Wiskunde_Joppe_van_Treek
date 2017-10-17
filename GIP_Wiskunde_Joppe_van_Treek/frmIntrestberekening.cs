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
    public partial class frmIntrestberekening : Form
    {
        public frmIntrestberekening()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Startpage fStart = new Startpage();
            fStart.Show();
            this.Close();

        }
    }
}
