//using System.Xml;
//using System.Xml.Linq;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace C_MiniProject1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //customerNames(List<string>) - the name of the customer who owns each account.
//            //accountNumbers(List<string>) - a unique account number for each account.
//            //balances(List<double>) - the current balance of each account.

//            List<string> customerNames = new List<string>();
//            List<string> accountNumbers = new List<string>();
//            List<string> balances = new List<string>();
//        }
//    }
//}


namespace BankingSystemApp
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<int> accountNumbers = new List<int>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. Update user name");
                Console.WriteLine("7. List All Acounts");
                Console.WriteLine("8. Close Account");
                Console.WriteLine("9. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {

                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter your name : ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Please enter new account number : ");
                        int newAccountNo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter  initial deposit amount : ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        AddAccount(customerNames, accountNumbers, balances, newAccountNo, depositAmount, name);


                        break;
                    case 2:
                        Console.WriteLine("Please enter your account number : ");
                        int findAccount = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter deposit amount : ");
                        depositAmount = double.Parse(Console.ReadLine());

                        DepositMoney(accountNumbers, balances, findAccount, depositAmount, customerNames);

                        break;
                    case 3:
                        Console.WriteLine("Please enter your account number : ");
                        findAccount = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter withdrawal amount : ");
                        double withdrawalAmount = double.Parse(Console.ReadLine());
                        WithdrawMoney(findAccount, withdrawalAmount, balances,
                                      accountNumbers, customerNames);
                        break;
                    case 4:
                        Console.WriteLine("Please enter account number : ");
                        findAccount = int.Parse(Console.ReadLine());

                        ShowBalance(findAccount, balances, accountNumbers, customerNames);
                        break;
                    case 5:
                        //Ask for the sender's account number and the receiver's account number, and find both indexes.
                        Console.WriteLine("Please enter sender's account number : ");
                        int senderAccount = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter receiver's account number : ");
                        int receiverAccount = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter transfer amount : ");
                        double transferAmount = double.Parse(Console.ReadLine());


                        TransferAmount(senderAccount, receiverAccount, transferAmount,
                                   balances, accountNumbers);
                        break;
                    case 6:
                        // TODO: call your first custom service function here
                        //Update user name
                        Console.WriteLine("Please enter your account number : ");
                        findAccount = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please enter the new name : ");
                        string newName = Console.ReadLine();
                        UpdateUserName(findAccount, accountNumbers, customerNames, newName, balances);


                        break;
                    case 7:
                        ListAllAccounts(accountNumbers, customerNames, balances);
                        break;
                    case 8:
                        // TODO: call your second custom service function here
                        //Delete account
                        Console.WriteLine("Please enter your account number : ");
                        findAccount = int.Parse(Console.ReadLine());
                        CloseAccount(findAccount, accountNumbers, customerNames, balances);
                        break;
                    case 9:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount(List<string> customerNames,
                               List<int> accountNumbers,
                               List<double> balances,
                               int newAccountNo,
                               double depositAmount,
                               string name)
        {
            // TODO: implement this service (see Section 3 requirements)
            foreach (int account in accountNumbers)
            {
                if (account == newAccountNo)
                {
                    Console.WriteLine("Error!!!");
                    return;
                }

            }
            if (depositAmount <= 0)
            {
                Console.WriteLine("Wrong amount only positive numbers are accepted");
                return;
            }

            customerNames.Add(name);
            accountNumbers.Add(newAccountNo);
            balances.Add(depositAmount);
            Console.WriteLine("New account added successfully!");
            Console.WriteLine($"Account Owner : {name}");
            Console.WriteLine($"Account Number : {newAccountNo} ");
            Console.WriteLine($"Account Balance : {depositAmount} ");

        }
        static void DepositMoney(List<int> accountNumbers,
                                          List<double> balances,
                                          int findAccount,
                                          double depositAmount,
                                          List<string> customerNames)
        {
            // TODO: implement this service (see Section 3 requirements)
            int index = accountNumbers.IndexOf(findAccount);

            if (index < 0)
            {
                Console.WriteLine("Account not fond try again");
                return;
            }
            else
            {
                if (depositAmount <= 0)
                {
                    Console.WriteLine("Wrong amount only positive numbers are accepted");
                    return;
                }
                balances[index] += depositAmount;
                Console.WriteLine("Amount updated successfully!");
                Console.WriteLine($"Account Owner : {customerNames[index]}");
                Console.WriteLine($"Account Number : {accountNumbers[index]} ");
                Console.WriteLine($"Account Balance : {balances[index]} ");
            }

        }
        static void WithdrawMoney(int findAccount,
                                  double withdrawalAmount,
                                  List<double> balances,
                                  List<int> accountNumbers,
                                  List<string> customerNames)
        {
            // TODO: implement this service (see Section 3 requirements)
            int index = accountNumbers.IndexOf(findAccount);
            if (index < 0)
            {
                Console.WriteLine("Account not fond try again");
                return;
            }
            if (withdrawalAmount > balances[index])
            {
                Console.WriteLine("Withdrawal Amount more than Balance!");
                return;
            }
            if (withdrawalAmount <= 0)
            {
                Console.WriteLine("Withdrawal Amount must be more than zero");
                return;
            }
            balances[index] -= withdrawalAmount;
            Console.WriteLine("Amount withdrawn successfully!");
            Console.WriteLine($"Account Owner : {customerNames[index]}");
            Console.WriteLine($"Account Number : {accountNumbers[index]} ");
            Console.WriteLine($"Account Balance : {balances[index]} ");
        }

        static void ShowBalance(int findAccount,
                                List<double> balances,
                                List<int> accountNumbers,
                                List<string> customerNames)
        {
            // TODO: implement this service (see Section 3 requirements)
            int index = accountNumbers.IndexOf(findAccount);
            if (index < 0)
            {
                Console.WriteLine("Account not fond try again");
                return;
            }
            Console.WriteLine("Account Details: ");
            Console.WriteLine($"Account Owner : {customerNames[index]}");
            Console.WriteLine($"Account Number : {accountNumbers[index]} ");
            Console.WriteLine($"Account Balance : {balances[index]} ");
        }
        static void TransferAmount(int senderAccount, int receiverAccount, double transferAmount,
                                   List<double> balances, List<int> accountNumbers)
        {
            // TODO: implement this service (see Section 3 requirements)
            int senderIndex = accountNumbers.IndexOf(senderAccount);
            int receiverIndex = accountNumbers.IndexOf(receiverAccount);
            if (senderIndex < 0 || receiverIndex < 0)
            {
                Console.WriteLine("Account not fond try again");
                return;
            }

            if (transferAmount > balances[senderIndex])
            {
                Console.WriteLine("Sender does not have sufficient balance");
                return;

            }
            if (transferAmount <= 0)
            {
                Console.WriteLine("Transfer Amount must be more than zero");
                return;
            }
            balances[senderIndex] -= transferAmount;
            balances[receiverIndex] += transferAmount;

            Console.WriteLine("Process done successfully ");
            Console.WriteLine($"Sender Account Balance: {balances[senderIndex]}");
            Console.WriteLine($"Receiver Account Balance:  {balances[receiverIndex]} ");
        }
            // TODO: write two more void, no-parameter functions here for
            // your own custom services (option 6 and option 7)
            static void UpdateUserName(int findAccount,List<int> accountNumbers,List<string> customerNames,
                                       string newName,List<double> balances)
            {
                int index = accountNumbers.IndexOf(findAccount);

                if (index < 0)
                {
                    Console.WriteLine("Account does not exist");
                    return;
                }

                customerNames[index] = newName;
                Console.WriteLine($"Customer details at account {findAccount} updated successfully");
                Console.WriteLine($"Customer name is :  {customerNames[index]}");
                Console.WriteLine($"Customer balance :  {balances[index]}");

            }
            static void ListAllAccounts(List<int> accountNumbers,
                                        List<string> customerNames,
                                        List<double> balances)
             {
            if (accountNumbers.Count == 0)
            {
                Console.WriteLine("No accounts exist.");
                return;
            }

            for (int i = 0; i < accountNumbers.Count; i++)
            {
                Console.WriteLine("---List of accounts---");
                Console.WriteLine($"Customer Name: {customerNames[i]}");
                Console.WriteLine($"Account Number: {accountNumbers[i]}");
                Console.WriteLine($"Customer balance: {balances[i]}");
            }
            }
        ///////////////////////
        static void CloseAccount(int findAccount,List<int> accountNumbers,List<string> customerNames, List<double> balances)
            {
            int index = accountNumbers.IndexOf(findAccount);

            if (index < 0)
            {
                Console.WriteLine("Account does not exist");
                return;
            }
            accountNumbers.RemoveAt(index);
            customerNames.RemoveAt(index);
            balances.RemoveAt(index);
            Console.WriteLine("Account deleted successfully");
            }

    }
}
