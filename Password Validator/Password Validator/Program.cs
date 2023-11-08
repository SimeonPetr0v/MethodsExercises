namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            bool isValid = PasswordValid(pass);
            if (isValid)
            {
                Console.WriteLine("Password is valid");
               
            }
            static bool PasswordValid(string pass)
            {
                
                int cheks = 0;
                if (IsLengthValid(pass)) cheks++;
                if(IsCharachterValid(pass)) cheks++;
                if(RequiredD(pass)) cheks++;
                 if(cheks == 3)
                {
                    return true;
                }
                 return false;
            }
            static bool IsLengthValid(string pass)
            {
                if (pass.Length < 6 || pass.Length > 10)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                    return false;
                }
                return true;
            }
            static bool IsCharachterValid(string pass) 
            { 
            foreach(char c in pass)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        Console.WriteLine("Password must consist only of letters and digits ");
                        return false;
                    }
                    
                }
            return true;
            }
            static bool RequiredD(string pass)
            {
                string num = "1234567890";
                int dCount = 0;
                foreach(char c in pass)
                {
                    if (num.Contains(c))
                    {
                        dCount++;
                    }
                }
                if (dCount >= 2)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Password must have at least 2 digits");
                    return false;
                }
            }
        }
    }
}