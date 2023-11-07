namespace Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            SmallestNumber(a, b, c);
            
        }
        static void SmallestNumber(int a, int b , int c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
            }
            else if (c < a && c < b)
            {
                Console.WriteLine(c);
            }
            else if(a == b && b == c)
            {
                Console.WriteLine(a);
            }
        }
    }
}