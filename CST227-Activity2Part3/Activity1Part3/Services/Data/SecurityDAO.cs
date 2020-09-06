using Activity1Part3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Services.Data
{
    public class SecurityDAO
    {
        public bool FindByUser(UserModel user)
        {
            using (SqlConnection connection = new SqlConnection("Data Source = (localdb)/MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Users", connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            
        }
    }
}