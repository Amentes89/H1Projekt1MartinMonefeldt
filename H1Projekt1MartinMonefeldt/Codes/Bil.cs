using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Projekt1MartinMonefeldt.Codes
{
    internal class Bil
    {
        public DateTime _sidsteSynsDato;
        private bool skalKaldesTilSyn;

        public static byte AlderForFørsteSyn;
        public static byte SynsInterval;

        public string EjerensNavn { get; set; }
        public string Mærke { get; set; }
        public string NummerPlade { get; set; }
        public Int16 Årgang { get; set; }


        public Bil(string ejerensNavn, string mærke, string nummerPlade, Int16 årgang)
        {

            EjerensNavn = ejerensNavn;
            Mærke = mærke;
            NummerPlade = nummerPlade;
            Årgang = årgang;

        }
        static Bil()
        {
            AlderForFørsteSyn = 5;
            SynsInterval = 2;
        }

        public void BilMetode()
        {


            if (DateTime.Now.Year - Årgang > 4)
            {
                Console.Write("Indtast venligst datoen for sidste syn i formatet dd-MM-yyyy: ");
                string? sidsteSynsDato = Console.ReadLine();

                int day = 0;
                int month = 0;
                int year = 0;

                if (sidsteSynsDato != null)
                {
                    string[] sidsteSynsDatoSplit = sidsteSynsDato.Split('-');
                    day = Convert.ToInt32(sidsteSynsDatoSplit[0]);
                    month = Convert.ToInt32(sidsteSynsDatoSplit[1]);
                    year = Convert.ToInt32(sidsteSynsDatoSplit[2]);
                }
                _sidsteSynsDato = new DateTime(year, month, day);

                TimeSpan ts = DateTime.Now - _sidsteSynsDato;
                if ((ts.TotalDays/365) > SynsInterval)
                {
                    skalKaldesTilSyn = true;
                }
            }
            if (skalKaldesTilSyn == true) Console.WriteLine("Bilen skal til syn.");
            else Console.WriteLine("Bilen skal ikke til syn.");
        }


    }
}


