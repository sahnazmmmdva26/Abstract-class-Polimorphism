using System.Security.Cryptography.X509Certificates;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("what would you like to do?\n");
            Console.WriteLine("1. Find area of square\n2. Find area of rectangular\n\nOr you can press 0 for quit");
            
            while (true)
            {
                Console.WriteLine("\nchoose one option:");
                int choise = Convert.ToInt16(Console.ReadLine());

                switch (choise)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("Please enter side of square :");
                        Square square = new Square(Convert.ToDouble(Console.ReadLine()));
                        square.CalcArea();
                        break;
                    case 2:
                        Console.WriteLine("Please enter width of rectangular :");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter length of rectangular :");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Rectangular rectangular = new Rectangular(width, length);
                        rectangular.CalcArea();
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
    }
}