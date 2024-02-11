using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Random Password: {PasswordGen()}");

            Console.ReadKey();
        }
        public static string PasswordGen()
        {
            string alphabets = "abcdefghijklmnopqrstuvwxyz1234567890][';/.><_+=!@#$%^&*()";
            Random ran = new Random();
            StringBuilder Password = new StringBuilder();

            for(int i = 1; i <= 25; i++)
            {
                int randomIndex = ran.Next(0, alphabets.Length);
                Password.Append(alphabets[randomIndex] );
            }
            return Password.ToString();
        }
    }
}
