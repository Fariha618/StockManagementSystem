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

        public int InsertCategory(Category category)
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"INSERT INTO Category (Name) VALUES ('" + category.Name + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public int UpdateCategory(Category category)
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"Update Category SET Name = '" + category.Name + "' WHERE Name = '" + category.oldName + "'  ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public DataTable ShowCategory()
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Category";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public int InsertCompany(Company company)
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"INSERT INTO Company (Name) VALUES ('" + company.Name + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public int UpdateCompany(Company company)
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"Update Company SET Name = '" + company.Name + "' WHERE Name = '" + company.oldName + "'  ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public DataTable ShowCompany()
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Company";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public DataTable LoadCompany()
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Company";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public DataTable LoadCategory()
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Category";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public int InsertItem(Item item)
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"INSERT INTO Item (Name, category_ID, company_ID, reorder_level) VALUES ('" + item.Name + "' , " + item.category_ID + " , " + item.company_ID + " , " + item.reorder_level + ")";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public int UpdateItem(Item item)
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"Update Item SET Name = '" + item.Name + "', company_ID = " + item.company_ID + ", category_ID = " + item.category_ID + ", reorder_level = " + item.reorder_level + " WHERE Name = '" + item.oldName + "' ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public DataTable ShowItem()
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM ItemView";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public DataTable LoadItem()
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Item";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }
    }
}
