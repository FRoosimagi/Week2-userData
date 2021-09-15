using System;

namespace Userage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib vanust;
            //Programm arvutab sünniaasta;
            //Programm kuvab arvutatud vanuse;

            Console.WriteLine("Palun sisestage oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 - userAge;

            Console.WriteLine($"Oled sündinud aastal {yearOfBirth}.");
        }
    }
}
