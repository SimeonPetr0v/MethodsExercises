using System.Security.Cryptography.X509Certificates;

namespace Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());
            ReadChars(c1, c2);

        }
        static void ReadChars(char start, char end)
        {
           char sChar;
            char eChar;
           if(start < end)
            {
                sChar = start;
                eChar = end;
            }
           else
            {
                sChar = end;
                eChar = start;
            }
           for(char i = ++sChar; i < eChar; i++)
            {
                Console.Write(i+ " ");
            }
           Console.WriteLine();
        }
    }
}