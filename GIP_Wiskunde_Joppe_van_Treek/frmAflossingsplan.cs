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
    public partial class frmAflossingsplan : Form
    {
        public frmAflossingsplan()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Startpage fStart = new Startpage();
            fStart.Show();
            this.Close();
        }

        private void frmAflossingsplan_Load(object sender, EventArgs e)
        {
            ComboboxItem item = new ComboboxItem();
            item.Text = "Kies een aflossing";
            item.Value = 0;
            cbKeuzeAflossing.Items.Add(item);
            cbKeuzeAflossing.SelectedIndex = 0;

            item = new ComboboxItem();
            item.Text = "Annuïteit aflossing";
            item.Value = 1;
            cbKeuzeAflossing.Items.Add(item);

            item = new ComboboxItem();
            item.Text = "Linaire aflossing";
            item.Value = 2;
            cbKeuzeAflossing.Items.Add(item);

            item = new ComboboxItem();
            item.Text = "Jaar";
            item.Value = 0;
            cbAnnuiteit.Items.Add(item);
            cbAnnuiteit.SelectedIndex = 0;

            item = new ComboboxItem();
            item.Text = "Kwartaal";
            item.Value = 1;
            cbAnnuiteit.Items.Add(item);

            item = new ComboboxItem();
            item.Text = "Maand";
            item.Value = 2;
            cbAnnuiteit.Items.Add(item);
        }

        private void cbKeuzeAflossing_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.SelectedItem as ComboboxItem).Value.ToString());
            if(Convert.ToInt32((cbKeuzeAflossing.SelectedItem as ComboboxItem).Value) !=0)
            {
                pnlValues.Visible = true;
                if (Convert.ToInt32((cbKeuzeAflossing.SelectedItem as ComboboxItem).Value) == 1)
                {
                    pnlAnnuiteit.Visible = true;
                }
                else
                {
                    pnlAnnuiteit.Visible = false;
                }
            }
            else
            {
                pnlValues.Visible = false;
                pnlAnnuiteit.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
