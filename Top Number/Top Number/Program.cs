namespace Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                if (TopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }


        }
        static bool TopNumber(int num)
        {
            int sum = 0;
            bool oddDigit = false;

            while(num > 0)
            {
                int digit = num % 10;
                sum+= digit;

                if(digit % 2 != 0)
                {
                    oddDigit = true;
                }
                num /= 10;
            }
            if(sum % 8 == 0 && oddDigit)
            {
               return true; 

            }
            return false;
        }
    }
}