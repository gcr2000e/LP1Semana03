using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("String: ");
            string s = Console.ReadLine();

            Console.Write("Caráter: ");
            char c = Console.ReadKey().KeyChar;

            char[] chars = s.ToCharArray();

            for(int i = 0; i < chars.Length; i++)
            {
               if (chars[i] == c)
               {
                   chars[i] = 'x';
               }
            }

            string StringModificada = new string(chars);
            Console.WriteLine("\nSerá impresso: " + StringModificada);
        }
    }
}
