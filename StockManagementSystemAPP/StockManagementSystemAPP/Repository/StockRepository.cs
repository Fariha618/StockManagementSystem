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

        SqlDataReader reader;

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

        public bool IsExistCategory(string name)
        {
            bool isExist = false;
            sqlConnection = new SqlConnection(connectionString);
            string query = "Select * From Category Where Name='" + name + "'";
            try
            {
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    isExist = true;
                }
            }
            catch (Exception)
            {
                isExist = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isExist;
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

        public bool IsExistCompany(string name)
        {
            bool isExist = false;
            sqlConnection = new SqlConnection(connectionString);
            string query = "Select * From Company Where Name='" + name + "'";
            try
            {
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    isExist = true;
                }
            }
            catch (Exception)
            {
                isExist = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isExist;
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

        public DataTable GetCompany(StockIn stockIn)
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT c.Name FROM Item AS i LEFT JOIN Company AS c ON c.ID = i.company_ID WHERE i.ID = " + stockIn.item_ID + " ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public DataTable GetCategory(StockIn stockIn)
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT c.Name FROM Item AS i LEFT JOIN Category AS c ON c.ID = i.category_ID WHERE i.ID = " + stockIn.item_ID + " ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public int GetReorderLevel(StockIn stockIn)
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"SELECT * FROM Item WHERE ID = " + stockIn.item_ID + " ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();            
            
            SqlDataReader dr = sqlCommand.ExecuteReader();
            dr.Read();

            int reorderLevel = dr.GetInt32(4);

            sqlConnection.Close();

            return reorderLevel;
        }

        public int GetAvailableQuantity(StockIn stockIn, StockOut stockOut)
        {
            sqlConnection = new SqlConnection(connectionString);

            commandString = @"SELECT ISNULL((SELECT SUM(stockin_quantity) FROM StockIn WHERE item_ID = " + stockIn.item_ID+ "),0) - ISNULL((SELECT SUM(stockout_quantity) FROM StockOut WHERE item_ID = " + stockIn.item_ID+"),0) ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();           

            SqlDataReader dr = sqlCommand.ExecuteReader();
            dr.Read();

            int availableQuantity = dr.GetInt32(0);

            sqlConnection.Close();
            
            return availableQuantity;
        }

        public int InsertStockIn(StockIn stockIn)
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"INSERT INTO StockIn (item_ID, stockin_quantity, Date) VALUES (" + stockIn.item_ID + ", " + stockIn.stockin_quantity + " , CONVERT(VARCHAR(10), getdate(), 103))";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public int InsertAvailableQuantity(StockIn stockIn)
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"UPDATE StockIn SET available_quantity = "+ stockIn.available_quantity+" WHERE item_ID = "+ stockIn.item_ID +" ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public DataTable ShowStockIn()
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM StockInView";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public int UpdateStockIn(StockIn stockIn)
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"Update StockIn SET item_ID = " + stockIn.item_ID + ", available_quantity = " + stockIn.available_quantity + ", stockin_quantity = " + stockIn.stockin_quantity + ", Date = CONVERT(VARCHAR(10), getdate(), 103) WHERE item_ID = " + stockIn.oldItem_ID + " ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public int InsertSell(StockOut stockOut)
        {
            sqlConnection = new SqlConnection(connectionString);

            commandString = @"INSERT INTO StockOut (item_ID, stockout_quantity, stockout_type, Date) VALUES (" + stockOut.item_ID + " , " + stockOut.stockout_quantity + " , 0 , CONVERT(VARCHAR(10), getdate(), 103))";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public int InsertLost(StockOut stockOut)
        {
            sqlConnection = new SqlConnection(connectionString);

            commandString = @"INSERT INTO StockOut (item_ID, stockout_quantity, stockout_type, Date) VALUES (" + stockOut.item_ID + " , " + stockOut.stockout_quantity + " , 1 , CONVERT(VARCHAR(10), getdate(), 103))";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public int InsertDamage(StockOut stockOut)
        {
            sqlConnection = new SqlConnection(connectionString);

            commandString = @"INSERT INTO StockOut (item_ID, stockout_quantity, stockout_type, Date) VALUES (" + stockOut.item_ID + " , " + stockOut.stockout_quantity + " , 2 , CONVERT(VARCHAR(10), getdate(), 103))";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int isExecuted;

            isExecuted = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return isExecuted;
        }

        public DataTable GetCategoryforSearch(ItemSummary itemSummary)
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT c.Name FROM Item AS i LEFT JOIN Category AS c ON c.ID = i.category_ID WHERE i.company_ID = " + itemSummary.companyID + " ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;

        }

        public DataTable GetCompanyforSearch(ItemSummary itemSummary)
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT c.Name FROM Item AS i LEFT JOIN Company AS c ON c.ID = i.company_ID WHERE i.category_ID = " + itemSummary.categoryID + " ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public DataTable SearchItem(ItemSummary itemSummary)
        {

            commandString = @"SELECT DISTINCT i.Name AS Item, co.Name AS Company, ca.Name AS Category, StockIn.available_quantity AS Available, reorder_level AS ReorderLevel FROM Item AS i
                              LEFT JOIN Company AS co ON co.ID = i.company_ID 
                              LEFT JOIN Category AS ca ON ca.ID = i.category_ID
                              LEFT JOIN StockIn ON StockIn.item_ID = i.ID
                              WHERE co.ID = " + itemSummary.companyID+" AND ca.ID = "+itemSummary.categoryID+"";
            
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
