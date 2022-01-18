
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Projekt1MartinMonefeldt.Codes
{
    internal class Person
    {
        private string? _firstName;
        private string? _lastName;
        /*
        public string BirthDateInDanishFormat { get; set; }
        public int Age { get; set; }
        public double TimeSpanInTotalDays { get; set; }
        public int TelephonNr { get; init; }
        */

        public PersonModel Model { get; set; }

        public Person(string firstName, string lastName, DateTime birthDate, Int32 _telephoneNr)
        {

            _firstName = firstName;
            _lastName = lastName;


            TimeSpan ts = DateTime.Now - birthDate;
            int age = DateTime.Now.Year - birthDate.Year;
            string birthDateInDanishFormat = birthDate.ToString("dd-MM-yyyy");
            double timeSpanInTotalDays = ts.TotalDays;
            Model = new PersonModel()
            {
                Age = age,
                BirthDateInDanishFormat = birthDateInDanishFormat,
                TelephonNr = _telephoneNr,
                TimeSpanInTotalDays = timeSpanInTotalDays,
            };
        }
        public Person()
        {
            _firstName = "Silas";
            _lastName = "Hansen";
        }

        public Person(PersonModel model)
        {
            Model = model;
        
        }
        public string? GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}