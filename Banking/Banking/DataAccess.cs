using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataBaseConnect;//class library
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Banking
{
    class DataAccess : IDataBaseItems
    {
        SqlConnection connect=null;
        List<Data> CustomerDetails;
        Data Access = null;
        public SqlConnection CreateConnection()
        {
            connect =Connection.DataBaseConnection();
            
            return connect;
           }

        public List<Data> DisplayElements()
        {
            CustomerDetails = new List<Data>();
            Access = new Data();
            try
            {
                SqlConnection con = CreateConnection();
                
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "DisplayAll";
                        SqlDataReader reader = cmd.ExecuteReader();
                       
                            while (reader.Read())
                            {
                                Access = new Data();
                                Access.AccountName = reader["AccountHolders"].ToString();
                                Access.Email = reader["EmailId"].ToString();
                                Access.Address = reader["Address"].ToString();
                                Access.contactno = reader["ContactNumber"].ToString();
                                Access.balance = Convert.ToInt32(reader["Balance"]);
                                Access.AccType = reader["AccountType"].ToString();
                                Access.accountno = Convert.ToInt64(reader["AccountNumber"]);
                            CustomerDetails.Add(Access);
                        }
                           
                        

                        reader.Close();
                    }

                con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return CustomerDetails;
        }

        public void InsertIntoDB(Data AccessPoint)
        {
            try
            {
                SqlConnection con = CreateConnection();
                
                    con.Open();
                    
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        //Console.WriteLine(AccessPoint.balance);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@AccountName",AccessPoint.AccountName);
                        cmd.Parameters.AddWithValue("@Email", AccessPoint.Email);
                        cmd.Parameters.AddWithValue("@Address", AccessPoint.Address);
                        cmd.Parameters.AddWithValue("@ContactNumber", AccessPoint.contactno);
                        cmd.Parameters.AddWithValue("@Balance", AccessPoint.balance);
                        cmd.Parameters.AddWithValue("@Type", AccessPoint.AccType);
                      
                        cmd.CommandText ="Insertion";
                        int result = cmd.ExecuteNonQuery();

                        if (result > 1)
                            Console.WriteLine("DONE");

                    }
                con.Close();
                }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }

        public List<Data> GetFromId(long Accno)
        {
            CustomerDetails = new List<Data>();
            Access = new Data();
            try
            {
                SqlConnection con = CreateConnection();
                
                    con.Open();
                    
                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Accno", Accno);
                            cmd.CommandText = "selectbyid";
                            SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Access.AccountName = reader["AccountHolders"].ToString();
                            Access.Email = reader["EmailId"].ToString();
                            Access.Address = reader["Address"].ToString();
                            Access.contactno = reader["ContactNumber"].ToString();
                            Access.balance = Convert.ToInt32(reader["Balance"]);
                            Access.AccType = reader["AccountType"].ToString();
                            Access.accountno = Convert.ToInt64(reader["AccountNumber"]);
                            CustomerDetails.Add(Access);

                        }
                        else
                        {
                            Console.WriteLine("Enter correct Account Number");
                            return null;
                        }    
                            reader.Close();
                        }
                con.Close();

            
                }
            
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            
            
            return CustomerDetails;
        }

        public String UpdateDB(long AccountNumber,int Amount)
        {
            try
            {
                SqlConnection con = CreateConnection();
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Accno",AccountNumber);
                        cmd.Parameters.AddWithValue("@Amount",Amount);
                        cmd.CommandText = "UpdateBalance";
                        int result = cmd.ExecuteNonQuery();

                        if (result > 1)
                            Console.WriteLine("DONE");
                    }
                }
                con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "Amount credited";
        }
        public String WithdrawUpdate(long AccountNumber, int Amount)
        {
            try
            {
                SqlConnection con = CreateConnection();
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Accno", AccountNumber);
                        cmd.Parameters.AddWithValue("@Amount",Amount);
                        cmd.CommandText = "updatewithdraw";
                        int result = cmd.ExecuteNonQuery();

                        if (result >= 1)
                            Console.WriteLine("DONE");
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "amount debited";

        }
    }
}
