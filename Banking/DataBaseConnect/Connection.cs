using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseConnect
{
    public class Connection
    {

       
           static SqlConnection connections = null;
        static string ConnectionString = "";
            public static SqlConnection DataBaseConnection()
            {
            //ConnectionString = "Data Source=TAVDESK083;Initial Catalog=AccountHolders;Integrated Security=True";

            string ConnectionString = "Data Source=TAVDESK083;Initial Catalog=AccountHolders;Integrated Security=True";
                if (connections == null)
                {
                  try
                    {
                    connections = new SqlConnection();
                    connections.ConnectionString = ConnectionString;
                  
                        Console.WriteLine("Connection created");
                        return connections;
                    }
                catch (SqlException ex)
                {
                    //Log exception
                    //Display Error message
                }
            }
                return connections;
            }
        }
    }

