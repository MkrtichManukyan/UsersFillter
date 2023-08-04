
using UsersFillter;


var employees = new List<Employee>
{
    new Employee
    {
        ID = "1",
        FirstName = "Vazgen",
        LastName = "Mnatsakanyan",
        Patronymic = "Axasu",
        YearOfBirth = "22/08/1982",
        Country = "Erevan, Avan",
        Profession = "Atamnabuyj",
        PhonNumber = 093713982,
    },
    new Employee
    {
        ID = "2",
        FirstName = "Armen",
        LastName = "Pogosyan",
        Patronymic = "Vartani",
        YearOfBirth = "10/01/1957",
        Country = "Erevan, Malatia",
        Profession = "Avtoelektrik",
        PhonNumber = 077212320,
    },
    new Employee
    {
        ID = "3",
        FirstName = "Artak",
        LastName = "Avagyan",
        Patronymic = "Tigrani",
        YearOfBirth = "06/08/1974",
        Country = "Erevan, Qanaqer",
        Profession = "Cragravorox",
        PhonNumber = 077838392,
    },
    new Employee
    {
        ID = "4",
        FirstName = "Arshak",
        LastName = "Stepanyan",
        Patronymic = "Taroni",
        YearOfBirth = "22/10/1986",
        Country = "Erevan, Avan",
        Profession = "Voskerich",
        PhonNumber = 094091209,
    },
    new Employee
    {
        ID = "5",
        FirstName = "Vladimir",
        LastName = "Minasyan",
        Patronymic = "Arami",
        YearOfBirth = "23/06/1983",
        Country = "Erevan, Malatia",
        Profession = "Atamnabuyj",
        PhonNumber = 055050555,
    },
    new Employee
    {
        ID = "6",
        FirstName = "Garik",
        LastName = "Vardanyan",
        Patronymic = "Gexami",
        YearOfBirth = "03/01/1958",
        Country = "Erevan, Qanaqer",
        Profession = "Cragravorox",
        PhonNumber = 098723456,
    },
    new Employee
    {
        ID = "7",
        FirstName = "Vardges",
        LastName = "Pogosyan",
        Patronymic = "Taroni",
        YearOfBirth = "17/05/1987",
        Country = "Erevan, Avan",
        Profession = "Avtoelektrik",
        PhonNumber = 055663426,
    },
    new Employee
    {
        ID = "8",
        FirstName = "Garnik",
        LastName = "Vardanyan",
        Patronymic = "Armen",
        YearOfBirth = "01/08/1993",
        Country = "Erevan, Malatia",
        Profession = "Cragravorox",
        PhonNumber = 098327612,
    },
    new Employee
    {
        ID = "9",
        FirstName = "Nerses",
        LastName = "Avagyan",
        Patronymic = "Taroni",
        YearOfBirth = "15/12/1965",
        Country = "Erevan, Qanaqer",
        Profession = "Avtoelektrik",
        PhonNumber = 093786757,
    },
    new Employee
    {
        ID = "10",
        FirstName = "Taron",
        LastName = "Stepanyan",
        Patronymic = "Vartani",
        YearOfBirth = "10/04/1982",
        Country = "Erevan, Malatia",
        Profession = "Cragravorox",
        PhonNumber = 055678797,
    }
};

var queriCountry = from emp in employees
                   where emp.Country == "Erevan, Malatia"
                   select new
                   {
                       ID = emp.ID,
                       FirstName = emp.FirstName,
                       LastName = emp.LastName,
                       Patronymic = emp.Patronymic,
                       YearOfBirth = emp.YearOfBirth,
                       Country = emp.Country,
                       Profession = emp.Profession,
                       PhonNumber = emp.PhonNumber
                   };

var queriCountry2 = from emp in employees
                   where emp.Country == "Erevan, Avan"
                    select new
                   {
                       ID = emp.ID,
                       FirstName = emp.FirstName,
                       LastName = emp.LastName,
                       Patronymic = emp.Patronymic,
                       YearOfBirth = emp.YearOfBirth,
                       Country = emp.Country,
                       Profession = emp.Profession,
                       PhonNumber = emp.PhonNumber
                   };

var queriProfession = from emp in employees
                   where emp.Profession == "Cragravorox"
                   select new
                   {
                       ID = emp.ID,
                       FirstName = emp.FirstName,
                       LastName = emp.LastName,
                       Patronymic = emp.Patronymic,
                       YearOfBirth = emp.YearOfBirth,
                       Country = emp.Country,
                       Profession = emp.Profession,
                       PhonNumber = emp.PhonNumber
                   };

var queriProfession2 = from emp in employees
                      where emp.Profession == "Avtoelektrik"
                       select new
                      {
                          ID = emp.ID,
                          FirstName = emp.FirstName,
                          LastName = emp.LastName,
                          Patronymic = emp.Patronymic,
                          YearOfBirth = emp.YearOfBirth,
                          Country = emp.Country,
                          Profession = emp.Profession,
                          PhonNumber = emp.PhonNumber
                      };


Console.WriteLine("Martiq Ovqer Aprum en Malatia - um");

foreach (var employ in queriCountry)
{
    Console.WriteLine(new string('-', 25));
    Console.WriteLine("ID" + " | " + employ.ID);
    Console.WriteLine("FirstName" + " | " + employ.FirstName);
    Console.WriteLine("LastName" + " | " + employ.LastName);
    Console.WriteLine("Patronymic" + " | " + employ.Patronymic);
    Console.WriteLine("YearOfBirth" + " | " + employ.YearOfBirth);
    Console.WriteLine("Country" + " | " + employ.Country);
    Console.WriteLine("Profession" + " | " + employ.Profession);
    Console.WriteLine("PhonNumber" + " | " + employ.PhonNumber);
};

Console.WriteLine(new string('-', 35));

Console.WriteLine("Martiq Ovqer Aprum en Avan - um");

foreach (var employ in queriCountry2)
{
    Console.WriteLine(new string('-', 25));
    Console.WriteLine("ID" + " | " + employ.ID);
    Console.WriteLine("FirstName" + " | " + employ.FirstName);
    Console.WriteLine("LastName" + " | " + employ.LastName);
    Console.WriteLine("Patronymic" + " | " + employ.Patronymic);
    Console.WriteLine("YearOfBirth" + " | " + employ.YearOfBirth);
    Console.WriteLine("Country" + " | " + employ.Country);
    Console.WriteLine("Profession" + " | " + employ.Profession);
    Console.WriteLine("PhonNumber" + " | " + employ.PhonNumber);
};

Console.WriteLine(new string('-', 35));

Console.WriteLine("Martiq Ovqer Cragravorox en");

foreach (var employ in queriProfession)
{
    Console.WriteLine(new string('-', 25));
    Console.WriteLine("ID" + " | " + employ.ID);
    Console.WriteLine("FirstName" + " | " + employ.FirstName);
    Console.WriteLine("LastName" + " | " + employ.LastName);
    Console.WriteLine("Patronymic" + " | " + employ.Patronymic);
    Console.WriteLine("YearOfBirth" + " | " + employ.YearOfBirth);
    Console.WriteLine("Country" + " | " + employ.Country);
    Console.WriteLine("Profession" + " | " + employ.Profession);
    Console.WriteLine("PhonNumber" + " | " + employ.PhonNumber);
};

Console.WriteLine(new string('-', 35));

Console.WriteLine("Martiq Ovqer Avtoelektrik en");

foreach (var employ in queriProfession2)
{
    Console.WriteLine(new string('-', 25));
    Console.WriteLine("ID" + " | " + employ.ID);
    Console.WriteLine("FirstName" + " | " + employ.FirstName);
    Console.WriteLine("LastName" + " | " + employ.LastName);
    Console.WriteLine("Patronymic" + " | " + employ.Patronymic);
    Console.WriteLine("YearOfBirth" + " | " + employ.YearOfBirth);
    Console.WriteLine("Country" + " | " + employ.Country);
    Console.WriteLine("Profession" + " | " + employ.Profession);
    Console.WriteLine("PhonNumber" + " | " + employ.PhonNumber);
};