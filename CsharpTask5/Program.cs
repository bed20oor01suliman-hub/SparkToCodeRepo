namespace CsharpTask5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /// Collections

            //[Array
            //List]=> for loop

            //Task 1 - Fixed Grades Array

            //int[] grades = new int[5];
            // for(int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write("Please Enter "+ (i+1) + " Grade : ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Output : ");
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            /////////////////////////////
            //Task 2 - Dynamic To-Do List

            //List<string> ToDo = new List<string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Write to do list: ");
            //    ToDo.Add(Console.ReadLine());
            //}
            //int N= 1;
            //Console.WriteLine("To Do List : ");
            //foreach(string list in ToDo)
            //{
            //    Console.WriteLine(N++ + ") " + list);
            //}

            /////////////////////////////
            //Task 3 - Browsing History Stack

            //Stack<string> browserPageHistory = new Stack<string>(3);
            //Console.WriteLine("Write first website URL");
            //browserPageHistory.Push(Console.ReadLine());
            //Console.WriteLine("Write second website URL");
            //browserPageHistory.Push(Console.ReadLine());
            //Console.WriteLine("Write third website URL");
            //browserPageHistory.Push(Console.ReadLine());

            //Console.WriteLine("Back...");
            //browserPageHistory.Pop();
            //Console.WriteLine(browserPageHistory.Peek());

            /////////////////////////////
            //Task 4 - Customer Service Queue
            //Queue<string> customerName = new Queue<string>(3);

            //    Console.Write("Write first customer name : ");
            //    customerName.Enqueue(Console.ReadLine());

            //    Console.Write("Write second customer name : ");
            //    customerName.Enqueue(Console.ReadLine());

            //    Console.Write("Write third customer name : ");
            //    customerName.Enqueue(Console.ReadLine());

            //    Console.Write("Served Customer Is : ");
            //    Console.WriteLine(customerName.Dequeue());



            /////////////////////////////
            //Task 5 - Array Grade Range
            int[] grades = new int[5];
             for(int i = 0; i < grades.Length; i++)
            {
                Console.Write("Please Enter "+ (i+1) + " Grade : ");
                grades[i] = int.Parse(Console.ReadLine());
                
            }
            Array.Sort(grades);
            //double avgGrade = grades.Peak() / 5;
            Console.WriteLine("Lowest Grade = " + grades[0]);
            Console.WriteLine("Highest Grade = " + grades[4]);
            //Two ways to get the average
            Console.WriteLine("Average of all 5 Grades = " + grades.Average());
            Console.WriteLine("Average of all 5 Grades = " + (grades[0]+ grades[1]+ grades[2]+ grades[3]+ grades[4])/5);

            //Task 6 - Filtered Shopping List

            //Task 7 - High Score Podium

            //Task 8 - Undo Last Action

            //Task 9 - Grade Analyzer with Functions

            //Task 10 - Print Queue Manager

            //Stack => LIFO
            //Push
            //Pop
            //Peek=> value of last one 
            //Count
            //Queue => FIFO
            //Enqueue
            //Dequeue
            //Peek => value of first one
            //Count

        }
    }
}
