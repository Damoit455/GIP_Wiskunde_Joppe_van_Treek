using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

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
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range formatRange;

            double[] test = null;
            double dblGeleend, dblRente,dblNogTeBetalen;
            int intLooptijd , intLooptijdper,intKeuze;
            dblGeleend = Convert.ToDouble(txtGeleend.Text);
            dblNogTeBetalen = Convert.ToDouble(txtGeleend.Text);
            dblRente = Convert.ToDouble(txtRente.Text);
            intKeuze = Convert.ToInt32((cbKeuzeAflossing.SelectedItem as cComboboxItem.ComboboxItem).Value);
            intLooptijd = Convert.ToInt32(txtLooptijd.Text);
            intLooptijdper = Convert.ToInt32((cbAnnuiteit.SelectedItem as cComboboxItem.ComboboxItem).Value);
            intLooptijd = cLooptijdBerekenen.Berekentijd(intLooptijdper, intLooptijd);

            xlWorkSheet.Cells[1, 1] = "Periode";
            xlWorkSheet.Cells[1, 2] = "Annuïteit";
            xlWorkSheet.Cells[1, 3] = "Rente";
            xlWorkSheet.Cells[1, 4] = "Aflossing";
            xlWorkSheet.Cells[1, 5] = "Nog te betalen";

            for (int i = 2; i < intLooptijd+2; i++)
            {
                test = Berekeningen.Aflossing(intKeuze, dblGeleend, dblNogTeBetalen, dblRente, intLooptijd, intLooptijdper);
                xlWorkSheet.Cells[i, 1] = i-1;
                xlWorkSheet.Cells[i, 2] = Math.Round(test[1],2);
                xlWorkSheet.Cells[i, 3] = Math.Round(test[2], 2);
                xlWorkSheet.Cells[i, 4] = Math.Round(test[3], 2);
                xlWorkSheet.Cells[i, 5] = Math.Round(test[0], 2);

                formatRange = xlWorkSheet.get_Range("b" + i, "e" + i);
                formatRange.NumberFormat = "$ #,###,###.00";

                dblNogTeBetalen = test[0];
            }
            xlWorkBook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            System.Diagnostics.Process.Start(@"d:\\csharp-Excel.xls");

        }
    }
}
