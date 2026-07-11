namespace CsharpTask1
{
    internal class Program
    {
        static void Main(string[] args)
        /*{
            //Task1: Personal Info Card
               string Name = "Badour";
               int Age = 24;
               double Height = 164;
               bool isStudent = true;

               Console.WriteLine("Name: "+  Name  + 
                                 ", Age: " +  Age  + 
                                 ", Height: " + Height +"M" + 
                                 ", Student: " + isStudent);
         }  }*/
        ///////////////////////////////////////////////////
        /*{
            //Task2: Rectangle Calculator
            Console.WriteLine("Enter  length of rectangle: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter  width of rectangle: ");
            int width = int.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (area + width);

            Console.WriteLine("Area = " + area + " & " + 
                              " Perimeter = " + perimeter);

        }*/
        ///////////////////////////////////////////////////
        /*{
            //Task3: Even or Odd Checker
            Console.WriteLine("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("It is Even number");
            }
            else
            {
                Console.WriteLine("It is Odd number");
            }
        }*/
        ///////////////////////////////////////////////////
        /*{
            //Task4: Voting Eligibility
            Console.WriteLine("Enter your age: ");
            int Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you have a valid ID? [yes/no]: ");
            string Answer = Console.ReadLine();

            bool hasID = Answer.ToLower() == "yes";

            if (Age >= 18 && hasID)
            {
                Console.WriteLine("You are eligible for voting");
            }
            else
            {
                Console.WriteLine("You are uneligible for voting");
            }
        }*/
        ///////////////////////////////////////////////////
        /*{
            //Task5: Grade Letter Lookup
            Console.WriteLine("Enter grade [A - B - C - D - F]: ");
            char Grade = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (Grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;

                case 'B':
                    Console.WriteLine("Very Good");
                    break;

                case 'C':
                    Console.WriteLine("Good");
                    break;

                case 'D':
                    Console.WriteLine("Pass");
                    break;

                case 'F':
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Invalid grade");
                    break;

            }*/
        ///////////////////////////////////////////////////
        /*{
            //Task6: Temperature Converter

            Console.WriteLine("Enter the temperature in Celsius: ");
            double Celsius = double.Parse(Console.ReadLine());

            double F = (Celsius * 9 / 5) + 32;

            string Weather;

            if (Celsius < 10)
                Weather = "Cold";
            else if (Celsius <= 30)
                Weather = "Mild";
            else
                Weather = "Hot";

            Console.WriteLine("Temperature in Fahrenheit: " + F + 
                              " && " + 
                              " Weather: " + Weather);
        }*/
        ///////////////////////////////////////////////////
        /*{
            //Task7: Movie Ticket Pricing
            Console.WriteLine("Enter your age: ");
            int Age = int.Parse(Console.ReadLine());
            double Price;
            string Category;
            if (Age < 0)
            {
                Console.WriteLine("Invalid age.");
            }
            else
            {
                if (Age <= 12)
                {
                    Category = "Child";
                    Price = 2.000;
                }
                else if (Age <= 59)
                {
                    Category = "Adult";
                    Price = 5.000;
                }
                else
                {
                    Category = "Senior";
                    Price = 3.000;
                }

                Console.WriteLine("Category: " + Category);
                Console.WriteLine("Ticket Price: " + Price + "OMR");
            }
        }*/
        ///////////////////////////////////////////////////
        /*{
            //Task8: Restaurant Bill with Membership Discount
            Console.WriteLine("Enter your total bill amount: ");
            double BillAmount = double.Parse(Console.ReadLine());

            Console.Write("Are you a loyalty member? [yes - no]: ");
            string CustomerMember = Console.ReadLine().ToLower();
            double Discount = 0;

            if (BillAmount > 20 && CustomerMember == "yes")
            {
                Discount = BillAmount * 0.15;
            }

            double FinalAmountPay = BillAmount - Discount;

            Console.WriteLine("Original Bill: " + BillAmount + " OMR");
            Console.WriteLine("Discount: " + Discount + " OMR");
            Console.WriteLine("Final Amount Pay: " + FinalAmountPay + " OMR");
        }*/
        ///////////////////////////////////////////////////
        /*{
            //Task9: Day Name Finder
            Console.WriteLine("Enter a number From 1 to 7 ): ");
            int Day = int.Parse(Console.ReadLine());

            switch (Day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
        }*/
        ///////////////////////////////////////////////////
        /*{
            //Task10: Mini Calculator
            Console.WriteLine("Enter first number: ");
            double Num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double Num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter Operator (+, -, *, /, %): ");
            char Operator = char.Parse(Console.ReadLine());

            switch (Operator)
            {
                case '+':
                    Console.WriteLine("Resultn of addition = " + (Num1 + Num2));
                    break;

                case '-':
                    Console.WriteLine("Result of subtraction = " + (Num1 - Num2));
                    break;

                case '*':
                    Console.WriteLine("Result of multiplication = " + (Num1 * Num2));
                    break;

                case '/':
                    if (Num2 != 0)
                        Console.WriteLine("Result of divition = " + (Num1 / Num2));
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;

                case '%':
                    if (Num2 != 0)
                        Console.WriteLine("Result = " + (Num1 % Num2));
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }*/
        ///////////////////////////////////////////////////
        /*{
            //Task11: Loan Eligibility System
            Console.WriteLine("Enter your age: ");
            int Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your monthly income [OMR]: ");
            double Income = double.Parse(Console.ReadLine());

            Console.WriteLine("Do you have an existing loan? [yes - no]: ");
            string Loan = Console.ReadLine().ToLower();

            if (Age >= 21 && Age <= 60 && Income >= 400 && Loan != "yes")
            {
                Console.WriteLine("Eligible for loan.");
            }
            else
            {
                if (Age < 21 || Age > 60)
                    Console.WriteLine("Not eligible: Age out of range.");
                else if (Income < 400)
                    Console.WriteLine("Not eligible: Income too low.");
                else if (Loan == "yes")
                    Console.WriteLine("Not eligible: Existing loan.");
            }
        }*/
        ///////////////////////////////////////////////////
        /*{
            //Task12: Shipping Cost Calculator
            Console.WriteLine("Enter region code [A, B, C]: ");
            char Region = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Enter package weight [KG]: ");
            double Weight = double.Parse(Console.ReadLine());

            double BaseCost = 0;
            double ExtraCharge = 0;

            switch (Region)
            {
                case 'A':
                    BaseCost = 1.000;
                    break;

                case 'B':
                    BaseCost = 3.000;
                    break;

                case 'C':
                    BaseCost = 7.000;
                    break;

                default:
                    Console.WriteLine("Invalid region");
                    return;
            }

            if (Weight > 5)
                ExtraCharge = 2.000;
            else if (Weight > 10)
                ExtraCharge = 5.000;
            else
                ExtraCharge = 0.000;
            double TotalCost = BaseCost + ExtraCharge;

            Console.WriteLine("Base Cost: " + BaseCost + " OMR");
            Console.WriteLine("Extra Charge: " + ExtraCharge + " OMR");
            Console.WriteLine("Total Shipping Cost: " + TotalCost + " OMR");
        }*/
        ///////////////////////////////////////////////////
        /*{
            //Task13: Triangle Type Classifier
            Console.WriteLine("Enter side 1 of the traingle: ");
            double Side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side 2 of the traingle: ");
            double Side2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter side 3 of the traingle: ");
            double Side3 = double.Parse(Console.ReadLine());

            if (Side1 + Side2 > Side3 &&
                Side1 + Side3 > Side2 &&
                Side2 + Side3 > Side1)
            {
                if (Side1 == Side2 && Side2 == Side3)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (Side1 == Side2 || Side1 == Side3 || Side2 == Side3)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Scalene");
                }
            }
            else
            {
                Console.WriteLine("Sides not forming a valid triangle");
            }
        }*/
        ///////////////////////////////////////////////////
        /*{
            //Task14: Online Store Checkout
            Console.WriteLine("[1] Headphones ");
            Console.WriteLine("[2] Keyboard ");
            Console.WriteLine("[3] Mouse ");
            Console.WriteLine("Enter product code [1, 2, 3]: ");
            int Code = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter quantity: ");
            int Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you have a discount coupon? [yes-no]: ");
            string Coupon = Console.ReadLine().ToLower();

            double UnitPrice = 0;

            switch (Code)
            {
                case 1:
                    UnitPrice = 8.500;
                    break;

                case 2:
                    UnitPrice = 12.000;
                    break;

                case 3:
                    UnitPrice = 5.000;
                    break;

                default:
                    Console.WriteLine("Invalid product code");
                    return;
            }

            double Subtotal = UnitPrice * Quantity;
            double Discount = 0;

            if (Coupon == "yes" && Subtotal > 20)
            {
                Discount = Subtotal * 0.10;
            }

            double AfterDiscount = Subtotal - Discount;
            double Tax = AfterDiscount * 0.05;
            double FinalTotal = AfterDiscount + Tax;

            Console.WriteLine("Subtotal: " + Subtotal + " OMR");
            Console.WriteLine("Discount: " + Discount + " OMR");
            Console.WriteLine("Tax: " + Tax + " OMR");
            Console.WriteLine("Final Total: " + FinalTotal + " OMR");
        
        }*/
        ///////////////////////////////////////////////////
        {
            //Task15: University Admission Decision
            Console.WriteLine("[S] Science ");
            Console.WriteLine("[A] Arts ");
            Console.WriteLine("Enter program type [S or A]: ");
            char Program = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Enter GPA (out of 4.0): ");
            double GPA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter entrance exam score: ");
            double Score = double.Parse(Console.ReadLine());

            Console.WriteLine("Do you have an extracurricular achievement? [yes - no]: ");
            string Activity = Console.ReadLine().ToLower();

            switch (Program)
            {
                case 'S':
                    Console.WriteLine("Program: Science");

                    if (GPA >= 3.0 && Score >= 75)
                    {
                        Console.WriteLine("Admitted");
                    }
                    else if (Activity == "yes")
                    {
                        Console.WriteLine("Conditionally Admitted");
                    }
                    else
                    {
                        Console.WriteLine("Not Admitted");
                    }
                    break;

                case 'A':
                    Console.WriteLine("Program: Arts");

                    if (GPA >= 2.5 && Score >= 60)
                    {
                        Console.WriteLine("Admitted");
                    }
                    else if (Activity == "yes")
                    {
                        Console.WriteLine("Conditionally Admitted");
                    }
                    else
                    {
                        Console.WriteLine("Not Admitted");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid program type");
                    break;
            }
        }

    }
}
