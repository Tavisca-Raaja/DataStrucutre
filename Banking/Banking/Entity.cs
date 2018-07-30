using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Entity
    {
        AccountHoldersEntities Account;
        List<AccountDetail> Fetcher;
        public Entity()
        {
            Account = new AccountHoldersEntities();
            Fetcher = new List<AccountDetail>();
        }
        public void AddAccount(string AccountHolderName, string EmailId, string Address, string ContactNumber, String Type, int Balance)
        {
            //Console.WriteLine("sss");
            var AccountDetail = new AccountDetail()
            {
                AccountHolders = AccountHolderName,
                EmailId = EmailId,
                Address = Address,
                ContactNumber = ContactNumber,
                Balance = Balance,
                AccountType = Type
            };
            Account.AccountDetails.Add(AccountDetail);
            Account.SaveChanges();
        }
        public void GetById(long AccountNumber)
        {
            Console.WriteLine("AccountHolder Name:" + Account.AccountDetails.Find(AccountNumber).AccountHolders);
            Console.WriteLine("Account Number:" + Account.AccountDetails.Find(AccountNumber).AccountType);
            Console.WriteLine("Contact number:" + Account.AccountDetails.Find(AccountNumber).Balance);
            Console.WriteLine("Balance:" + Account.AccountDetails.Find(AccountNumber).ContactNumber);
        }
        public void Display()
        {
            Fetcher = Account.AccountDetails.ToList();
            foreach(AccountDetail user in Fetcher)
            {
                Console.WriteLine("AccountHolder Name:"+user.AccountHolders);
                Console.WriteLine("Account Number:" + user.AccountNumber);
                Console.WriteLine("Contact number:" + user.ContactNumber);
                Console.WriteLine("Balance:" + user.Balance);
            }
        }
       
        public void Deposit(long AccountNumber,int Amount)
        {
            Account.AccountDetails.Find(AccountNumber).Balance += Amount;
            Console.WriteLine("New Balance" + Account.AccountDetails.Find(AccountNumber).Balance);
        }
        public void WithDraw(long AccountNumber,int Amount)
        {
            if (Account.AccountDetails.Find(AccountNumber).Balance > Amount)
            {
                Account.AccountDetails.Find(AccountNumber).Balance -= Amount;
                Console.WriteLine("New Balance" + Account.AccountDetails.Find(AccountNumber).Balance);
            }
            else
                Console.WriteLine("Your Balance is Insufficient");

        }
        public void calculateInterest(long AccountNumber)
        {
            if (Account.AccountDetails.Find(AccountNumber).AccountType.Equals("Savings"))
                Console.WriteLine("Your Interest:" + (Account.AccountDetails.Find(AccountNumber).Balance * 4) / 100);
            else if ((Account.AccountDetails.Find(AccountNumber).AccountType.Equals("Current")))
                Console.WriteLine("Your Interest:" + (Account.AccountDetails.Find(AccountNumber).Balance) / 100);
            else
                Console.WriteLine("Your Account Has no Interest");
        }
    }
    }

