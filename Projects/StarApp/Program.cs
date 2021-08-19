using System;

namespace StarApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("-= StarApp =-");
            Console.Write("Write any number: ");
            var userImput = Console.ReadLine();

            var lenght = int.Parse(userImput);
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("+");
            }
        }
    }
}