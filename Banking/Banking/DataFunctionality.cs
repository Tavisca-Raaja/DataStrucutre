using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Banking
{
    class DataFunctionality
    {

        private Data _Element = null;
        private DataAccess _InsertHelper = null;
        public void AddAccount(string AccountHolderName, string EmailId, string Address, string ContactNumber, String Type, int Balance)
        {
           // Console.WriteLine(Balance);
            _Element = new Data();
            _Element.AccountName = AccountHolderName;
            _Element.Email = EmailId;
            _Element.Address = Address;
            _Element.contactno = ContactNumber;
            _Element.AccType = Type;
            _Element.balance = Balance;
            _InsertHelper = new DataAccess();
            _InsertHelper.InsertIntoDB(_Element);
        }
        public void SearchById(long AccountNumber)
        {
            _InsertHelper = new DataAccess();
            List<Data> IndividualDetails = _InsertHelper.GetFromId(AccountNumber);
            if (IndividualDetails != null)
                foreach (Data ob in IndividualDetails)
                {
                    Console.WriteLine("Name:" + ob.AccountName);
                    Console.WriteLine("Address:" + ob.Address);
                    Console.WriteLine("ContactNumber:" + ob.contactno);
                    Console.WriteLine("Balance:" + ob.balance);
                    Console.WriteLine("AccountNumber" + ob.accountno);
                }


        }
        public void Display()
        {
            _InsertHelper = new DataAccess();
            List<Data> AllUser = _InsertHelper.DisplayElements();

            foreach (Data ob in AllUser)
            {
                Console.WriteLine("Name:" + ob.AccountName);
                Console.WriteLine("Address:" + ob.Address);
                Console.WriteLine("ContactNumber:" + ob.contactno);
                Console.WriteLine("Balance:" + ob.balance);
                Console.WriteLine("AccountNumber" + ob.accountno);
                Console.WriteLine("<--------------->");
            }
        }
        public void Deposit(long AccountNumber, int Amount)
        {
            _InsertHelper = new DataAccess();
            String res = _InsertHelper.UpdateDB(AccountNumber, Amount);
            Console.WriteLine(res);
        }
        public void Withdraw(long AccountNumber, int Amount)
        {
            _InsertHelper = new DataAccess();
            String res = _InsertHelper.WithdrawUpdate(AccountNumber, Amount);
            Console.WriteLine(res);
        }
        public void CalculateInterest(long AccountNumber)
        {
            _InsertHelper = new DataAccess();
            List<Data> IndividualDetails = _InsertHelper.GetFromId(AccountNumber);
            if (IndividualDetails != null)
                foreach (Data ob in IndividualDetails)
                {
                   // Console.WriteLine((ob.balance));

                    if (ob.AccType.Equals("Current"))
                        Console.WriteLine("Interest percentage:"+(ob.balance * 1) / 100);
                    else if (ob.AccType.Equals("Savings"))
                        Console.WriteLine("Interest percentage: " + (ob.balance * 4) / 100);


                }


        }
    }
}

