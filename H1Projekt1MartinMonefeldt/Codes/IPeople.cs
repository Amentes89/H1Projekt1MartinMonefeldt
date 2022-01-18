using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Projekt1MartinMonefeldt.Codes
{
    internal interface IPeople
    {
        public PersonModel Model { get; set; }
        public string? GetFullName();
    }
}
