namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            
            Console.WriteLine(CheckIfLetterIsContained(word));
            
        }
        static int CheckIfLetterIsContained(string word)
        {
            string vowel = "aouie";
            int num = 0;
            foreach (char c in word.ToLower())
            {
                if (vowel.Contains(c))
                {
                    num++;
                }
            }
            
            return num;

        }
    }
}