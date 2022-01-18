using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Projekt1MartinMonefeldt.Codes
{
    internal struct AgeConverter
    {
        public int Age { get; set; }

        public AgeConverter(DateTime birthDate)
        {
            Age = DateTime.Now.Year - birthDate.Year;
        }
    }
}
