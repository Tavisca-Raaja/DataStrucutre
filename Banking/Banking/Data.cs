using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Data
    {
        private String _AccountHolderName, _EmailId, _Address, _ContactNumber,_AccountType;
        private int _Balance = 0;
        private long _AccountNumber;
       
        public Data()
        {
           
            _AccountHolderName = "";
            _EmailId = "";
            _Address = "";
            _ContactNumber = "";
            _AccountType = "";
            _Balance = 0;
            _AccountNumber =0;
        }
        public string AccountName
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string contactno
        {
            get;
            set;
        }
        
        public int balance
        {
            get;
            set;
        }
        public long accountno
        {
            get;
            set;
        }
        public String AccType
        {
            get;
            set;
        }
    }
}
