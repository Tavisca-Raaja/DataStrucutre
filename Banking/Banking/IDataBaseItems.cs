using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Banking
{
    interface IDataBaseItems
    {

        void InsertIntoDB(Data AccessPoint);
        List<Data> GetFromId(long AccountNo);
        String UpdateDB(long AccountNumber, int Amount);
        String WithdrawUpdate(long AccountNumber, int Amount);
        List<Data> DisplayElements();
        SqlConnection CreateConnection();
    }
}
