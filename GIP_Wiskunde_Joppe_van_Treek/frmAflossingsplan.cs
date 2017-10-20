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
            cComboboxItem.ComboboxItem item = new cComboboxItem.ComboboxItem();
            item.Text = "Kies een aflossing";
            item.Value = 0;
            cbKeuzeAflossing.Items.Add(item);
            cbKeuzeAflossing.SelectedIndex = 0;

            item = new cComboboxItem.ComboboxItem();
            item.Text = "Annuïteit aflossing";
            item.Value = 1;
            cbKeuzeAflossing.Items.Add(item);

            item = new cComboboxItem.ComboboxItem();
            item.Text = "Linaire aflossing";
            item.Value = 2;
            cbKeuzeAflossing.Items.Add(item);

            item = new cComboboxItem.ComboboxItem();
            item.Text = "Jaar";
            item.Value = 0;
            cbAnnuiteit.Items.Add(item);
            cbAnnuiteit.SelectedIndex = 0;

            item = new cComboboxItem.ComboboxItem();
            item.Text = "Kwartaal";
            item.Value = 1;
            cbAnnuiteit.Items.Add(item);

            item = new cComboboxItem.ComboboxItem();
            item.Text = "Maand";
            item.Value = 2;
            cbAnnuiteit.Items.Add(item);
            
        }

        private void cbKeuzeAflossing_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.SelectedItem as ComboboxItem).Value.ToString());
            if(Convert.ToInt32((cbKeuzeAflossing.SelectedItem as cComboboxItem.ComboboxItem).Value) !=0)
            {
                pnlValues.Visible = true;
                if (Convert.ToInt32((cbKeuzeAflossing.SelectedItem as cComboboxItem.ComboboxItem).Value) == 1)
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

        private void btnBereken_Click(object sender, EventArgs e)
        {
            double[] test;
            double dblGeleend, dblRente,dblNogTeBetalen;
            int intLooptijd , intLooptijdper,intKeuze;
            dblGeleend = Convert.ToDouble(txtGeleend.Text);
            dblNogTeBetalen = Convert.ToDouble(txtGeleend.Text);
            dblRente = Convert.ToDouble(txtRente.Text);
            intKeuze = Convert.ToInt32((cbKeuzeAflossing.SelectedItem as cComboboxItem.ComboboxItem).Value);
            intLooptijd = Convert.ToInt32(txtLooptijd.Text);
            intLooptijdper = Convert.ToInt32((cbAnnuiteit.SelectedItem as cComboboxItem.ComboboxItem).Value);
            test= Berekeningen.Aflossing(intKeuze,dblGeleend,dblNogTeBetalen,dblRente,intLooptijd,intLooptijdper);
            MessageBox.Show(test[0].ToString() + " " + test[1].ToString() + " " + test[2].ToString() + " " + test[3].ToString() );
        }
    }
}
