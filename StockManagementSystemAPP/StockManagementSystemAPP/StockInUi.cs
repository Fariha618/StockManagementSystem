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
            displayStockIn.DataSource = _stockManager.ShowItem(); ;

            companyComboBox.DataSource = _stockManager.LoadCompany();
            categoryComboBox.DataSource = _stockManager.LoadCategory();            

            itemComboBox.DataSource = _stockManager.LoadItem();

            reorderLevelTextBox.Text = "0";
            reorderLevelTextBox.ReadOnly = true;
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
                

                reorderLevelTextBox.Text = _stockManager.GetReorderLevel(stockIn);
                availableQuantityTextBox.Text = _stockManager.GetAvailableQuantity(stockIn, stockOut).ToString();



            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            stockIn.item_ID = Convert.ToInt32(itemComboBox.SelectedValue);
            stockIn.available_quantity = _stockManager.GetAvailableQuantity(stockIn, stockOut);
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

            displayStockIn.DataSource = _stockManager.ShowItem();
        }
    }
}
