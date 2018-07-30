using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
       
        static void Main(string[] args)
        {
            String AccountHolderName, EmailId, Address, ContactNumber,AccountType;
            int Balance = 0;
            
            long AccountNumber;
            Console.WriteLine("Banking Application");
            
            //Console.WriteLine("Enter Your Choice:");
           
            int Choice=0;
            
            DataFunctionality newuser = new DataFunctionality();
            Entity newuser1 = new Entity();
            int flag = 1;
            string Decision = "";

            do
            {
                Console.WriteLine("1) Add Account");
                Console.WriteLine("2) Get AccountDetails");
                Console.WriteLine("3) Display");
                Console.WriteLine("4) Deposit ");
                Console.WriteLine("5) withdraw");
                Console.WriteLine("6)  calculate interest");
                Console.WriteLine("Enter Your Choice:");
                Choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter E for Entity and A for Ado.net");
                Decision = Console.ReadLine();
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Enter the AccountHolderName");
                        AccountHolderName = Console.ReadLine();
                        Console.WriteLine("Enter the EmailId");
                        EmailId = Console.ReadLine();
                        Console.WriteLine("Enter the Address");
                        Address = Console.ReadLine();
                        Console.WriteLine("Enter the ContactNumber");
                        ContactNumber = Console.ReadLine();
                        Console.WriteLine("Enter the AccountType");
                        AccountType = Console.ReadLine();
                        Console.WriteLine("Enter the Minimum Balance:");
                        Balance = Convert.ToInt32(Console.ReadLine());
                        //Console.WriteLine(Balance);
                        
                        if(Decision.Equals("E"))
                            newuser1.AddAccount(AccountHolderName, EmailId, Address, ContactNumber, AccountType, Balance);
                        else
                        newuser.AddAccount(AccountHolderName, EmailId, Address, ContactNumber, AccountType, Balance);

                        break;
                    case 2:
                        Console.WriteLine("Enter the Account Number:");
                        AccountNumber = Convert.ToInt64(Console.ReadLine());
                        if (Decision.Equals("E"))
                            newuser1.GetById(AccountNumber);
                        else
                        newuser.SearchById(AccountNumber);
                        break;
                    case 3:
                        Console.WriteLine("All User Details:");
                        if (Decision.Equals("E"))
                            newuser1.Display();
                        else
                            newuser.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the Account Number:");
                        AccountNumber = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter the Amount to be Deposied:");
                        Balance = Convert.ToInt32(Console.ReadLine());
                        if (Decision.Equals("E"))
                            newuser1.Deposit(AccountNumber, Balance);
                        else
                            newuser.Deposit(AccountNumber, Balance);
                        break;
                    case 5:
                        Console.WriteLine("Enter the Account Number:");
                        AccountNumber = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter the Amount to be Withdrawed:");
                        Balance = Convert.ToInt32(Console.ReadLine());
                        if (Decision.Equals("E"))
                            newuser1.WithDraw(AccountNumber, Balance);
                        else
                            newuser.Withdraw(AccountNumber, Balance);
                        break;
                    case 6:
                        Console.WriteLine("Enter the Account Number:");
                        AccountNumber = Convert.ToInt64(Console.ReadLine());
                        if (Decision.Equals("E"))
                            newuser1.calculateInterest(AccountNumber);
                        else
                            newuser.CalculateInterest(AccountNumber);
                        break;
                }
                Console.WriteLine("Enter 1 to Continue And 2 to exit:");
                flag = Convert.ToInt32(Console.ReadLine());

            } while (flag == 1);
                Console.ReadKey();
            
        }
    }
}
