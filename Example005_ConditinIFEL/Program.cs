using System;

namespace Example005_ConditinIFEL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя");
            string username = Console.ReadLine();

            if (username.ToLower() == "маша")

            {
                Console.WriteLine("Ура, это же Маша!");
            }
            
            else
            
            {
                Console.Write("Привет, ");
                Console.WriteLine(username);
            }
        }
    }
}
