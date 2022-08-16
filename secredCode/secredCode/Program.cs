using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secredCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "12345";
            int numberOfAttempts = 3;
            string userInput;

            Console.WriteLine("Тут хранится секрет который ты сможешь узнать" +
                " введя секретный код");
            Console.WriteLine("Введите пароль: ");

            for (int i = 0; i < numberOfAttempts; i++)
            {
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("Пароль конечно верный, но секрет я вам не расскажу");
                    break;
                } 
                else
                {
                    Console.WriteLine($"У вас осталось - {numberOfAttempts - i - 1}, что бы узнать тайну");
                }
            }
            Console.WriteLine("Ну вот и все");
            Console.ReadKey();
        }
    }
}
