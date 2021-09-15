using System;

namespace Userdata
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib sünniaastat
            //programm arvutab vanuse
            //programm kuvab arvutatud vanuse

            Console.WriteLine("Palun sisestage oma sünniaasta");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            Console.WriteLine("Oled " + userAge + " aastat vana.");


            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana.");
            




        }
    }
}
