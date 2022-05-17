using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApp_oop2_Lab
{
    class SqlOperations
    {
        public static SqlConnection connection = new SqlConnection("Data Source=LAPTOP-R4PTUFT9;Initial Catalog=person;Integrated Security=True");
        public static void CheckConnection(SqlConnection tempConnection)
        {
            if (tempConnection.State == ConnectionState.Closed)
            {
                tempConnection.Open();
                
            }
            else { }
        }
    }
}
