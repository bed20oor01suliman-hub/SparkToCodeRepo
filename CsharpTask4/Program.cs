using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpTask4
{
    internal class Program
    {
        //main function originak
        //function before or after the main
        //EASY(4 Tasks)
        //Task 1 - Personalized Welcome Function

        public static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome " + name.ToUpper());
        }

        ///////////////////////////////////////////////////
        //Task 2 - Square Number Function
        public static int Square(int num)
        {
            return num*num;
        }

        ///////////////////////////////////////////////////
        //Task 3 - Celsius to Fahrenheit Function
        public static double CelsiusToFahrenheit(double Celsius)
        {
            return (Celsius * 9 / 5) + 32;
        }

        ///////////////////////////////////////////////////
        //Task 4 - Fixed Menu Display Function
        public static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }


        ///////////////////////////////////////////////////
        //MEDIUM(4 Tasks)
        //Task 5 - Even or Odd Function
        public static bool IsEven(int num1)
        {
            if ((num1 % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////
        //Task 6 - Rectangle Area & Perimeter Functions
        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        ///////////////////////////////////////////////////
        //Task 7 - Grade Letter Function
        public static string GetGradeLetter(int score)
        {
            if (score >= 90 )
            {
                return "A";
            }
            else if (score >= 80 && score < 90 )
            {
                return "B";
            }
            else if (score >=70 && score < 80)
            {
                return "C";
            }
            else if (score >= 60 && score < 70)
            {
                return "D";
            }
            else
            {
                return "F";
            }
            
        }

        ///////////////////////////////////////////////////
        //Task 8 - Countdown Function
        public static void Countdown(int startNum)
        {
            for(int i = startNum; i >= 1; i-- )
            {
                Console.WriteLine(i);
            }
        }

        //HARD(2 Tasks)
        //Task 9 - Overloaded Multiply Function
        public static int Multiply(int p1, int p2)
        {

        }
        public static double Multiply(double p3, double p4)
        {

        }
        public static void Multiply()
        {

        }

        ///////////////////////////////////////////////////
        //Task 10 - Overloaded Area Calculator



        ///////////////////////////////////////////////////
        //ADVANCED(2 Tasks)
        //Task 11 - Function - Based Calculator


        ///////////////////////////////////////////////////
        //Task 12 - Student Report Card Generator


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            PrintWelcome(name);

            ///////////////////////////
            
            Console.WriteLine("Please enter Number: ");
            int num = int.Parse(Console.ReadLine());
            int result = Square(num);
            Console.WriteLine("Result : " + result);

            ////////////////////////////
            
            Console.WriteLine("Please enter Temperature in Celsius: ");
            double Celsius = double.Parse(Console.ReadLine());
            double Fahrenheit = CelsiusToFahrenheit(Celsius);
            Console.WriteLine("Temperature in Fahrenheit : " + Fahrenheit);

            ///////////////////////////
            ///
            Console.WriteLine("Menu");
            DisplayMenu();

            ///////////////////////////
            ///
            Console.WriteLine("Enter a number : ");
            int num1 = int.Parse(Console.ReadLine());
            bool even = IsEven(num1);
            if (even)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            //////////////////////////
            ///
            Console.WriteLine("Please enter length of rectangle : ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter width of rectangle : ");
            double width = double.Parse(Console.ReadLine());

            double areaResult = CalculateArea(length, width);
            double perimeterResult = CalculatePerimeter(length, width);

            Console.WriteLine("Area result : " + areaResult);
            Console.WriteLine("Perimeter result : " + perimeterResult);

            ///////////////////////////
            ///
            Console.WriteLine("Please write your score : ");
            int num2 = int.Parse(Console.ReadLine());
            string result1 = GetGradeLetter(num2);
            Console.WriteLine("Your grade is : " + result1);

            //////////////////////////
            ///
            Console.WriteLine("Please enter Start Number: ");
            int startNum = int.Parse(Console.ReadLine());
            Countdown(startNum);
        }
    }
}
