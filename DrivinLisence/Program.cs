using System;

namespace DrivinLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem kui 18 siis programm kuvab konsoolis (oled liiga noor)
            //kui kasutava on vanem kui 18, siis programm kuvab (oled piisavalt vana)
            //kui kasutaja on 18, siis programm kuvab (Palju õnne! Nüüd sa saad ka juhiluba taotleda)

            Console.WriteLine("Palun sisestage oma sünniaasta");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            if(userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba taotleda");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhiluba taotleda");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad ka juhiluba taotleda");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
