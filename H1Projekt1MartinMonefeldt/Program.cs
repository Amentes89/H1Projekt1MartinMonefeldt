global using H1Projekt1MartinMonefeldt.Codes;

Person p = new("Martin", "Monefeldt", new DateTime(1989, 7, 28), 28868090);




Console.WriteLine(p.GetFullName());
//Console.WriteLine(p.BirthDateInDanishFormat);
//Console.WriteLine(p.Age);
//Console.WriteLine(p.TimeSpanInTotalDays);

Person p2 = new();

Console.WriteLine(p2.GetFullName());