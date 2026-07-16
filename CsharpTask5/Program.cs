using System.Runtime.ExceptionServices;

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

            //int[] grades = new int[5];
            // for(int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write("Please Enter "+ (i+1) + " Grade : ");
            //    grades[i] = int.Parse(Console.ReadLine());

            //}
            //Array.Sort(grades);
            ////double avgGrade = grades.Peak() / 5;
            //Console.WriteLine("Lowest Grade = " + grades[0]);
            //Console.WriteLine("Highest Grade = " + grades[4]);
            ////Two ways to get the average
            //Console.WriteLine("Average of all 5 Grades = " + grades.Average());
            //Console.WriteLine("Average of all 5 Grades = " + (grades[0]+ grades[1]+ grades[2]+ grades[3]+ grades[4])/5);

            /////////////////////////////
            //Task 6 - Filtered Shopping List
            //bool exit = false;
            //List<string> shoppingList = new List<string>();
            //while (exit == false)
            //{
            //    Console.WriteLine("Write your shoping list if you finish write (done): ");
            //    string item = Console.ReadLine();
            //    if (item.ToLower() == "done")
            //    {
            //        exit = true;
            //    }
            //    else
            //    {
            //        shoppingList.Add(item.ToLower());
            //    }
            //}
            //Console.WriteLine("Shopping List : ");
            //foreach(string item in shoppingList)
            //{ 
            //    Console.WriteLine(item.ToLower());
            //}
            //Console.WriteLine("Wirte one item you don't need : ");
            //shoppingList.Remove(Console.ReadLine().ToLower());

            //Console.WriteLine("Shopping List After Removal: ");

            //foreach (string item in shoppingList)
            //{
            //    Console.WriteLine(item.ToLower());
            //}

            /////////////////////////////
            //Task 7 - High Score Podium
            //List<int> gameScore = new List<int>(5);
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Write five game scores: ");
            //    gameScore.Add(int.Parse(Console.ReadLine()));
            //}
            //gameScore.Sort();
            //gameScore.Reverse();

            //Console.WriteLine("Top 3 scores");
            //Console.WriteLine("1st place: " + gameScore[0]);
            //Console.WriteLine("2nd place: " + gameScore[1]);
            //Console.WriteLine("3rd place: " + gameScore[2]);



            /////////////////////////////
            //Task 8 - Undo Last Action
            //Stack<string> trackActions = new Stack<string>();
            //bool exit = false;
            //string write;
            //Console.WriteLine("Please enter your action if you done press(stop): ");
            //while (exit == false)
            //{
            //    write = Console.ReadLine();

            //    if (write.ToLower() == "stop")
            //    {
            //        exit = true;
            //    }
            //    else
            //    {
            //        trackActions.Push(write);
            //    }
            //}
            //Console.WriteLine("Please write (undo) : ");
            //write = Console.ReadLine();
            //if (write.ToLower() == "undo")
            //{
            //    Console.WriteLine("Undo... "+trackActions.Pop());
            //    Console.WriteLine("Undo... "+trackActions.Pop());
            //}
            //else
            //{
            //    Console.WriteLine("Not enough actions to undo.");
            //}
            //Console.WriteLine("Actions that are remain : ");
            //foreach (string action in trackActions)
            //{
            //    Console.WriteLine(action);
            //}


            /////////////////////////////
            //Task 9 - Grade Analyzer with Functions


            /////////////////////////////
            //Task 10 - Print Queue Manager







            ////////////////////////////////////////
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
            ////////////////////////////////////////
        }
    }
}
