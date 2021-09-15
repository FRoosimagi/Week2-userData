using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib vanust
            //Programm kontollib, kas vanus on vähemalt 13
            //kui vanus on sobiv siis võib instagrammi kasutada
            //kui vanus ei ole sobiv, siis ei või instagrammi kasutada

            Console.WriteLine("Palun, sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
            {
                Console.WriteLine("oled piisavalt vana, et kontot luua");

            }
            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et kontot luua");
            }
            else
            {
                Console.WriteLine("oled piisavalt vana, et kontot luua");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
