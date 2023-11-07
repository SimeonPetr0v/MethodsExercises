namespace Student_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());
            GetStudentsData(name, grade);
        }
        static void GetStudentsData(string name, int grade) =>
            Console.WriteLine($"{name} is studying in {grade} grade.");
    }
}