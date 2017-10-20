using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_Wiskunde_Joppe_van_Treek
{
    static class Berekeningen
    {
        public static double[] Aflossing(int intKeuze,double dblStartbedrag , double dblNogTeBetalenBedrag,double dblRente,int intLooptijd,int intBerekenPer)
        {
            double[] retvalue = null;
            dblRente /= 100;
            if (intKeuze == 1)
            {
                //retvalue[Nog te betalen , Annuiteit, betaalderente,aflossing]
                double dblAnnuiteit,dblBedaaldeRente,dblAflossing,dblNogTebetalen;
                switch (intBerekenPer)
                {
                    case 0:
                        intLooptijd /= 12;
                        dblAnnuiteit = (dblRente / (1-(Math.Pow((1 + dblRente),-(intLooptijd))))) * dblStartbedrag;
                        dblAnnuiteit = Math.Round(dblAnnuiteit, 2);
                        dblBedaaldeRente = Math.Round(dblNogTeBetalenBedrag * dblRente,2);
                        dblAflossing = Math.Round(dblAnnuiteit - dblBedaaldeRente, 2);
                        dblNogTebetalen = Math.Round(dblNogTeBetalenBedrag - dblAflossing,2);
                        retvalue = new double[] { dblNogTebetalen, dblAnnuiteit, dblBedaaldeRente, dblAflossing };
                        break;
                    case 1:
                        dblRente /= 4;
                        intLooptijd /= 3;
                        dblAnnuiteit = (dblRente / (1 - (Math.Pow((1 + dblRente), -(intLooptijd))))) * dblStartbedrag;
                        dblAnnuiteit = Math.Round(dblAnnuiteit, 2);
                        dblBedaaldeRente = Math.Round(dblNogTeBetalenBedrag * dblRente, 2);
                        dblAflossing = Math.Round(dblAnnuiteit - dblBedaaldeRente, 2);
                        dblNogTebetalen = Math.Round(dblNogTeBetalenBedrag - dblAflossing,2);
                        retvalue = new double[] { dblNogTebetalen, dblAnnuiteit, dblBedaaldeRente, dblAflossing };
                        break;
                    case 2:
                        dblRente /= 12;
                        dblAnnuiteit = (dblRente / (1 - (Math.Pow((1 + dblRente), -(intLooptijd))))) * dblStartbedrag;
                        dblAnnuiteit = Math.Round(dblAnnuiteit, 2);
                        dblBedaaldeRente = Math.Round(dblNogTeBetalenBedrag * dblRente, 2);
                        dblAflossing = Math.Round(dblAnnuiteit - dblBedaaldeRente, 2);
                        dblNogTebetalen = Math.Round(dblNogTeBetalenBedrag - dblAflossing,2);
                        retvalue = new double[] { dblNogTebetalen, dblAnnuiteit, dblBedaaldeRente, dblAflossing };
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
