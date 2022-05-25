using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounsleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region First Program
            //Console.WriteLine("Hello and welcome to my first line of code");

            //Console.WriteLine("Please enter your name");
            //string guestName = Console.ReadLine();
            //Console.WriteLine("Thank you " + guestName);
            //Console.ReadLine();
            #endregion

            #region Data Type
            //int favNum1 = 10;
            //string firstName = "Nikhil";
            //bool isPermenantEmployee = true;
            //double height = 6.2;

            //Console.WriteLine("Enter First Numer");
            //int firstNum = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Second Number");
            //int secondNum = Convert.ToInt32(Console.ReadLine());

            //int addition = firstNum + secondNum;
            //int subtraction = firstNum - secondNum;
            //int multiplication = firstNum * secondNum;
            //int division = firstNum / secondNum;

            //Console.WriteLine("Addition of your numbers are : " + addition);
            //Console.WriteLine("Subtraction of your numbers are : " + subtraction);
            //Console.WriteLine("Multiplication of your numbers are : " + multiplication);
            //Console.WriteLine("Division of your numbers are : " + division);
            #endregion

            #region conditions

            #region simple if conditions

            //Console.WriteLine("Please enter number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num>= 0)
            //{
            //Console.WriteLine("Good and is a positive number");
            //}
            //else
            //{
            //Console.WriteLine("Bad as it is a negative number");
            //}
            #endregion
            //Console.WriteLine("Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num < 0)
            //{
            //  Console.WriteLine("Bad Number");
            //}
            //else if (num> 0 && num <=10)
            //{
            //  Console.WriteLine("Good Number");  
            //}
            //else if (num >10 && num <= 20)
            //{
            //  Console.WriteLine("Very Good Number");
            //}
            //else if (num > 20 && num <= 30)
            //{
            //  Console.WriteLine("Excellent Number");
            //}
            //else
            //{
            //  Console.WriteLine("Number is way more than excellent");
            //}
            #endregion

            #region Login

            //Console.WriteLine("~~~~~~~~Welcome to Banking~~~~~~~~~");
            //Console.WriteLine("Enter User Name");
            //string username = Console.ReadLine();

            //Console.WriteLine("Enter password");
            //string password = Console.ReadLine();

            //if (username == "SteringC" && password == "pass@word")
            //{
              //  Console.WriteLine("Login Successful");
            //}
            //else
            //{
              //  Console.WriteLine("Invalid Credentials");
            //}
            #endregion

            #region SwitchCase 
            Console.WriteLine("~~~~~~~~Welcome to Banking~~~~~~~~~");
            Console.WriteLine("1. Open a New Account");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Wire Funds");
            Console.WriteLine("5. View Previous Transactions");
            Console.WriteLine("6. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please provide details and documents to open a new account");
                    Console.WriteLine("Code coming soon");
                    break;
                case 2:
                    Console.WriteLine("Enter Withdraw Amount");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Withdraw of $" + amount + " was successful");
                    break;
                case 3:
                    Console.WriteLine("Enter Deposit Amount");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Deposit of $" + deposit + " was successful");
                    break;
                case 4:
                    Console.WriteLine("Wire Funds Processing...");
                    Console.WriteLine("Funds Transfered");
                    break;
                case 5:
                    Console.WriteLine("Transaction History");
                    Console.WriteLine("Transaction 1");
                    Console.WriteLine("Transaction 2");
                    Console.WriteLine("Transaction 3");
                    break;
                case 6:
                    Console.WriteLine("Thank you for Banking with us");
                    break;
                default:
                    Console.WriteLine("Sorry you chose the wrong option");
                    break;
            }
            #endregion
        }
    }
}



