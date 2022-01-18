
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Projekt1MartinMonefeldt.Codes
{
    enum People
    {
        Teacher,
        Student,
        OfficeWorker
    }
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

            int age = (new AgeConverter(birthDate)).Age;

            TimeSpan ts = DateTime.Now - birthDate;
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