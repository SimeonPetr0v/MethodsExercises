using System.Net;

namespace Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetMidCharachter(Console.ReadLine());
        }
        static void GetMidCharachter (string text)
        {
            if(text.Length % 2 == 0)
            {
                Console.WriteLine(text[(text.Length / 2) - 1].ToString() + text[text.Length / 2].ToString());
            }
            else
            {
                Console.WriteLine(text[text.Length / 2]);
            }
        }
    }
}