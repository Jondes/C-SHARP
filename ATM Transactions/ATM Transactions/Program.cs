using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Transactions
{
    class program
    {
        public static void Main()
        {
            int amount = 2034, deposit, withdraw;
            int choice, pin = 0;
            Console.WriteLine("Please Enter Your 4 Digit PIN CODE ");
            pin = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("WELCOME TO YES BANK ATM SERVICE\n");
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("***************\n\n");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR CURRENT BALANCE IS Rs : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                        withdraw = int.Parse(Console.ReadLine());

                        if (withdraw % 100 != 0)
                            {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT 100 OR ABOVE");
                            }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");
                            Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("\n YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY");
                        Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);
                        break;
                    case 4:
                        const string Value = ("\n THANK YOU");
                        Console.WriteLine(Value);
                            break;

                }
                Console.WriteLine("\n Thank you for visiting YES ATM Service");
                Console.WriteLine("\n **************************************");
                Console.WriteLine("\n                                       ");


            }

        }
    }
}
