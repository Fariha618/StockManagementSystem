using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystemAPP.Models;


namespace StockManagementSystemAPP.Repository
{
    class StockRepository
    {

        string connectionString = @"Server=FARIHA; Database=StockDB; Integrated Security=True";
        SqlConnection sqlConnection;

        private string commandString;
        private SqlCommand sqlCommand;


    }
}
