namespace Day9_EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empwage for multiple companies");

            Class8.computeEmpWage("Adidas", 30, 30, 100);
            Class8.computeEmpWage("Nike", 20, 20, 100);
            Class8.computeEmpWage("Puma", 20, 20, 100);
        }
    }
}