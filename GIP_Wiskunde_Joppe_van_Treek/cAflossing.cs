using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_Wiskunde_Joppe_van_Treek
{
    static class Berekeningen
    {
        public static double[] Aflossing(int intKeuze, double dblGBedrag,double dblRente,int intLooptijd,int intBerekenPer)
        {
            double[] retvalue = null;
            if (intKeuze == 1)
            {
                double dblAnnuiteit;
                switch (intBerekenPer)
                {
                    case 0:
                        intLooptijd /= 12;
                        dblAnnuiteit = (dblRente / (1-(Math.Pow((1 + dblRente),-(intLooptijd))))) * dblGBedrag;
                        dblAnnuiteit = Math.Round(dblAnnuiteit, 2);
                        retvalue = new double[] { dblAnnuiteit, 92, 81, 60 };
                        break;
                    case 1:
                        dblRente /= 4;
                        intLooptijd /= 3;
                        dblAnnuiteit = (dblRente / (1 - (Math.Pow((1 + dblRente), -(intLooptijd))))) * dblGBedrag;
                        dblAnnuiteit = Math.Round(dblAnnuiteit, 2);
                        retvalue = new double[] { dblAnnuiteit, 92, 81, 60 };
                        break;
                    case 2:
                        dblRente /= 12;
                        dblAnnuiteit = (dblRente / (1 - (Math.Pow((1 + dblRente), -(intLooptijd))))) * dblGBedrag;
                        dblAnnuiteit = Math.Round(dblAnnuiteit, 2);
                        retvalue = new double[] { dblAnnuiteit, 92, 81, 60 };
                        break;
                }
            }
            else
            {
                retvalue = new double[] { 97, 92, 81, 60 };
            }

            
            return retvalue;
        }      
    }
}
