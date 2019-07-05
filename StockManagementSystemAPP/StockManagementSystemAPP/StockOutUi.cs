using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemAPP.Models;
using StockManagementSystemAPP.BLL;


namespace StockManagementSystemAPP
{
    public partial class StockOutUi : Form
    {
        StockManager _stockManager = new StockManager();
        private StockOut stockOut;
        private StockIn stockIn;

        DataTable dataTable = new DataTable();
        DataRow dataRow;

        List<int> item_IDs = new List<int>();
        int ID ;

        public StockOutUi()
        {
            InitializeComponent();
            stockOut = new StockOut();
            stockIn = new StockIn();            
            
            dataTable.Columns.Add("SI");            
            dataTable.Columns.Add("Item");
            dataTable.Columns.Add("Company");
            dataTable.Columns.Add("Quantity");
        }

        private void StockOutUi_Load(object sender, EventArgs e)
        {
            companyComboBox.DataSource = _stockManager.LoadCompany();
            categoryComboBox.DataSource = _stockManager.LoadCategory();

            itemComboBox.DataSource = _stockManager.LoadItem();

            reorderLevelTextBox.Text = "0";
            reorderLevelTextBox.ReadOnly = true;

            availableQuantityTextBox.Text = "0";
            availableQuantityTextBox.ReadOnly = true;

            companyComboBox.Enabled = false;
            categoryComboBox.Enabled = false;
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemComboBox.SelectedIndex > -1)
            {
                alertLebel.Text = "";
                stockIn.item_ID = Convert.ToInt32(itemComboBox.SelectedValue);

                companyComboBox.Enabled = true;
                categoryComboBox.Enabled = true;
                companyComboBox.DataSource = _stockManager.GetCompany(stockIn);
                categoryComboBox.DataSource = _stockManager.GetCategory(stockIn);

                int reorderLevel = _stockManager.GetReorderLevel(stockIn);
                reorderLevelTextBox.Text = reorderLevel.ToString();

                int availableQuantity;
                availableQuantity = _stockManager.GetAvailableQuantity(stockIn, stockOut);
                availableQuantityTextBox.Text = availableQuantity.ToString();

                if(availableQuantity < reorderLevel)
                {
                    MessageBox.Show("Please Restock This Item");
                    alertLebel.Text = "Please Restock This Item";
                }
                
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            dataRow = dataTable.NewRow();

            ID = Convert.ToInt32(itemComboBox.SelectedValue);
            item_IDs.Add(ID);
            dataRow["Item"] = itemComboBox.Text;
            dataRow["Company"] = companyComboBox.Text;
            dataRow["Quantity"] = stockOutQuantityTextBox.Text;

            dataTable.Rows.Add(dataRow);            

            displayStockOut.DataSource = dataTable;
            stockOutQuantityTextBox.Clear();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            int isExecuted = 0;

            for (int i = 0; i < displayStockOut.Rows.Count - 1; i++)
            {
                stockOut.item_ID = item_IDs[i];
                stockOut.stockout_quantity = Convert.ToInt32(displayStockOut.Rows[i].Cells[3].Value);

               
            }


            isExecuted = _stockManager.InsertSell(stockOut);

            if (isExecuted > 0)
            {
                MessageBox.Show("Saved As Sold Items");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            displayStockOut.Columns.Clear();
            
        }

        private void LostButton_Click(object sender, EventArgs e)
        {
            int isExecuted =0;

            for (int i = 0; i < displayStockOut.Rows.Count - 1; i++)
            {
                stockOut.item_ID = item_IDs[i];
                stockOut.stockout_quantity = Convert.ToInt32(displayStockOut.Rows[i].Cells[3].Value);

                
                isExecuted = _stockManager.InsertLost(stockOut);
                
            }

            if (isExecuted > 0)
            {
                MessageBox.Show("Saved As Lost Items");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            displayStockOut.Columns.Clear();

        }

        private void DamageButton_Click(object sender, EventArgs e)
        {
            int isExecuted = 0; ;

            for (int i = 0; i < displayStockOut.Rows.Count - 1; i++)
            {
                stockOut.item_ID = item_IDs[i];
                stockOut.stockout_quantity = Convert.ToInt32(displayStockOut.Rows[i].Cells[3].Value);

                
                isExecuted = _stockManager.InsertDamage(stockOut);
                                
            }

            if (isExecuted > 0)
            {
                MessageBox.Show("Saved As Damaged Items");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            displayStockOut.Columns.Clear();
        }
    }
}
