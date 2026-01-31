using System.ComponentModel.Design;

namespace TASK_2___Student_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //           //(int id, string name, string email, int grade)
            //           Student Student =new Student(1,"kholoud" , "kholoud @gmail ", 96);

            //           Console.WriteLine(" data of student:");

            //           Student.DisplayInfo();
            //           Console.WriteLine("enter grade of student ");
            //int grade = int.Parse(Console.ReadLine());
            //           Student.SetGrade (grade);

            //           double gpa = Student.GetGPA(grade);
            //           Console.WriteLine($"GPA: {gpa}");




            //BankAccount account = new BankAccount("12365478932541", "kholoud ", 6000.0);
            //Console.WriteLine("Bank Account Information:");
            //account.DisplayInfo();

            //Console.WriteLine("Enter a  BankacountNumber : ");

            //string BankacountNumber = Console.ReadLine();
            //account.AccountNumber = BankacountNumber;
            //Console.WriteLine("Enter a  BankacountName");
            //string name = Console.ReadLine();
            //account.OwnerName = name;
            //Console.WriteLine("Enter Deposit Amount: ");

            //double depsite = double.Parse(Console.ReadLine());

            //account.Deposit(depsite);

            //Console.WriteLine("Updated data:");
            //account.DisplayInfo();




            //Console.WriteLine("ENTER AMOUNT TO WITHDRAW");
            //double withdrawamount = double.Parse(Console.ReadLine());
            //account.Withdraw(withdrawamount);
            //Console.WriteLine("Updated balance after withdrawal:");
            //account.DisplayInfo();

            //;


            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("12365498745632", "ice", 5000.0));

            Console.WriteLine("All Bank Accounts:");
            foreach (var acc in accounts)
            {
                acc.DisplayInfo();
                Console.WriteLine();
            }


            Console.WriteLine("------------------");
            Console.WriteLine("Enter details for new bank account:");
            Console.Write("Account Number: ");
            string accountNumber = Console.ReadLine();
            Console.Write("Owner Name: ");
            string ownerName = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine());

            BankAccount newAccount = new BankAccount(accountNumber, ownerName, initialBalance);
            accounts.Add(newAccount);

            Console.WriteLine("\nAll Bank Accounts:");
            foreach (var acc in accounts)
            {
                acc.DisplayInfo();
                Console.WriteLine();

            }
            Console.WriteLine("Enter Account Number to withdraw from: ");
            string accNumber = Console.ReadLine();
             bool found = false;
            foreach (var item in accounts)
            { 


                if (item.AccountNumber == accNumber)
                {



                    Console.WriteLine("Enter Withdraw Amount: ");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    item.Withdraw(withdrawAmount);
                    Console.WriteLine("Updated balance after withdrawal:");

                    item.DisplayInfo();
                    found = true;
                    break;
                }
            }
            if ( !found)
            {

                Console.WriteLine("Account not found.");
                return;

            }


        }




    }
}