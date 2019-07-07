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
    public partial class StockInUi : Form
    {
        StockManager _stockManager = new StockManager();
        private StockIn stockIn;
        private StockOut stockOut;

        public StockInUi()
        {
            InitializeComponent();
            stockIn = new StockIn();
            stockOut = new StockOut();
        }

        private void StockInUi_Load(object sender, EventArgs e)
        {
            displayStockIn.DataSource = _stockManager.ShowItem();

            editLink.LinkColor = Color.Black;
            editLink.Text = "Edit";
            editLink.TrackVisitedState = true;
            editLink.UseColumnTextForLinkValue = true;

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
                displayStockIn.DataSource = _stockManager.ShowStockIn();

                stockIn.item_ID = Convert.ToInt32(itemComboBox.SelectedValue);

                companyComboBox.Enabled = true;
                categoryComboBox.Enabled = true;
                companyComboBox.DataSource = _stockManager.GetCompany(stockIn);
                categoryComboBox.DataSource = _stockManager.GetCategory(stockIn);


                reorderLevelTextBox.Text = _stockManager.GetReorderLevel(stockIn).ToString();

                int availableQuantity;
                availableQuantity = _stockManager.GetAvailableQuantity(stockIn, stockOut);
                availableQuantityTextBox.Text = availableQuantity.ToString();


            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (SaveButton.Text == "Save")
                {
                    stockIn.item_ID = Convert.ToInt32(itemComboBox.SelectedValue);

                    if (String.IsNullOrEmpty(stockInQuantityTextBox.Text))
                    {
                        stockInLabel.Text = "Stock In Quantity Field Can Not Be Empty!";
                        SaveButton.Text = "Save";
                        return;
                    }

                    stockInLabel.Text = "";

                    if (System.Text.RegularExpressions.Regex.IsMatch(stockInQuantityTextBox.Text, "[^0-9]"))
                    {
                        stockInLabel.Text = "Enter Only Digits";
                        return;
                    }

                    stockInLabel.Text = "";



                    stockIn.stockin_quantity = Convert.ToInt32(stockInQuantityTextBox.Text);

                    int isExecuted;
                    isExecuted = _stockManager.InsertStockIn(stockIn);

                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Saved");
                    }
                    else
                    {
                        MessageBox.Show("Not Saved");
                    }

                    stockInQuantityTextBox.Clear();
                    reorderLevelTextBox.Text = "0";
                    reorderLevelTextBox.ReadOnly = true;

                    availableQuantityTextBox.Text = "0";
                    availableQuantityTextBox.ReadOnly = true;

                    companyComboBox.Enabled = false;
                    categoryComboBox.Enabled = false;

                    int availableQuantity;
                    availableQuantity = _stockManager.GetAvailableQuantity(stockIn, stockOut);
                    stockIn.available_quantity = availableQuantity;

                    _stockManager.InsertAvailableQuantity(stockIn);
                }                
            

            else if (SaveButton.Text == "Update")
                {
                    stockIn.item_ID = Convert.ToInt32(itemComboBox.SelectedValue);

                    if (String.IsNullOrEmpty(stockInQuantityTextBox.Text))
                    {
                        stockInLabel.Text = "Stock In Quantity Field Can Not Be Empty!";

                        return;
                    }

                    stockInLabel.Text = "";

                    if (System.Text.RegularExpressions.Regex.IsMatch(stockInQuantityTextBox.Text, "[^0-9]"))
                    {
                        stockInLabel.Text = "Enter Only Digits";

                        return;
                    }
                    stockInLabel.Text = "";


                    stockIn.stockin_quantity = Convert.ToInt32(stockInQuantityTextBox.Text);

                    int isExecuted;
                    isExecuted = _stockManager.UpdateStockIn(stockIn);

                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Updated");
                    }
                    else
                    {
                        MessageBox.Show("Not Updated");
                    }

                    companyComboBox.DataSource = _stockManager.LoadCompany();
                    categoryComboBox.DataSource = _stockManager.LoadCategory();

                    itemComboBox.DataSource = _stockManager.LoadItem();

                    reorderLevelTextBox.Text = "0";
                    reorderLevelTextBox.ReadOnly = true;

                    availableQuantityTextBox.Text = "0";
                    availableQuantityTextBox.ReadOnly = true;

                    companyComboBox.Enabled = false;
                    categoryComboBox.Enabled = false;

                    stockInQuantityTextBox.Clear();

                    SaveButton.Text = "Save";                    

                    int availableQuantity;
                    availableQuantity = _stockManager.GetAvailableQuantity(stockIn, stockOut);
                    stockIn.available_quantity = availableQuantity;

                    _stockManager.InsertAvailableQuantity(stockIn);
                }

                displayStockIn.DataSource = _stockManager.ShowStockIn();

            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        } 

        private void displayStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                displayStockIn.DataSource = _stockManager.ShowStockIn();
               
                itemComboBox.Text = displayStockIn.Rows[e.RowIndex].Cells[1].Value.ToString();
                
                stockIn.oldItem_ID = Convert.ToInt32(itemComboBox.SelectedValue);                

                companyComboBox.Enabled = true;
                categoryComboBox.Enabled = true;
                companyComboBox.DataSource = _stockManager.GetCompany(stockIn);
                categoryComboBox.DataSource = _stockManager.GetCategory(stockIn);


                reorderLevelTextBox.Text = _stockManager.GetReorderLevel(stockIn).ToString();

                int availableQuantity;
                availableQuantity = _stockManager.GetAvailableQuantity(stockIn, stockOut);
                availableQuantityTextBox.Text = availableQuantity.ToString();

                stockInQuantityTextBox.Text = displayStockIn.Rows[e.RowIndex].Cells[3].Value.ToString();

                SaveButton.Text = "Update";


            }
        }

        private void displayStockIn_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            displayStockIn.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
