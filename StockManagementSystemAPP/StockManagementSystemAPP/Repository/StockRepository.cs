﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            catch (Exception )
            {
                isExist = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isExist;
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
            catch (Exception )
            {
                isExist = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isExist;
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
        public bool IsExistItem(string name)
        {
            bool isExist = false;
            sqlConnection = new SqlConnection(connectionString);
            string query = "Select * From Item Where Name='" + name + "'";
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
            catch (Exception )
            {
                isExist = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isExist;
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

        public string GetReorderLevel(StockIn stockIn)
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"SELECT * FROM Item WHERE ID = " + stockIn.item_ID + " ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();


            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            string reorderLevel = "";

            foreach (DataRow dc in dataTable.Rows)
            {
                reorderLevel = dataTable.Rows[0][4].ToString();
            }

            sqlConnection.Close();

            return reorderLevel;
        }

        public int GetAvailableQuantity(StockIn stockIn, StockOut stockOut)
        {
            sqlConnection = new SqlConnection(connectionString);

            commandString = @"SELECT stockin_quantity, s.stockout_quantity FROM StockIn INNER JOIN StockOut AS s ON StockIn.item_ID = s.item_ID WHERE  StockIn.item_ID = " + stockIn.item_ID + " ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();


            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            int available = 0;

            foreach (DataRow dc in dataTable.Rows)
            {
                available = (int.Parse(dataTable.Rows[0][0].ToString()) - int.Parse(dataTable.Rows[0][1].ToString()));
            }
            sqlConnection.Close();

            return available;
        }

        public int InsertStockIn(StockIn stockIn)
        {

            sqlConnection = new SqlConnection(connectionString);

            commandString = @"INSERT INTO StockIn (item_ID, available_quantity, stockin_quantity, Date) VALUES (" + stockIn.item_ID + " , " + stockIn.available_quantity + " , " + stockIn.stockin_quantity + " , CONVERT(VARCHAR(10), getdate(), 103))";
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


        public DataTable LoadStockOutToDataGridView(Report report)
        {

            sqlConnection = new SqlConnection(connectionString);

            //commandString = @" SELECT * FROM StockOut WHERE '" + action + "'='0' AND Date BETWEEN '" + fromDate + "' AND '" + toDate + "' ORDER BY Date DESC ";
            commandString = @" SELECT i.Name AS Item, co.Name AS Company, stockout_quantity As Quantity FROM StockOut AS s LEFT JOIN Item AS i ON i.ID = s.item_ID LEFT JOIN Company AS co ON co.ID = i.company_ID WHERE s.Date BETWEEN '"+report.fromDate + "' AND '" + report.toDate + "' AND s.stockout_type = "+report.action +" ORDER BY s.Date DESC";

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
