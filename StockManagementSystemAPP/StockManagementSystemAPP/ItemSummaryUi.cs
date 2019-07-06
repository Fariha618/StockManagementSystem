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
    public partial class ItemSummaryUi : Form
    {
        StockManager _stockManager = new StockManager();
        private ItemSummary itemSummary;
        private StockIn stockIn;
        private StockOut stockOut;

        public ItemSummaryUi()
        {
            InitializeComponent();
            itemSummary = new ItemSummary();
            stockIn = new StockIn();
            stockOut = new StockOut();
        }

        private void ItemSummaryUi_Load(object sender, EventArgs e)
        {
            companyComboBox.DataSource = _stockManager.LoadCompany();
            categoryComboBox.DataSource = _stockManager.LoadCategory();
        }

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (companyComboBox.SelectedIndex > -1)
            {
                itemSummary.companyID = Convert.ToInt32(companyComboBox.SelectedValue);
                categoryComboBox.DataSource = _stockManager.GetCategoryforSearch(itemSummary);
            }

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex > -1)
            {
                itemSummary.categoryID = Convert.ToInt32(categoryComboBox.SelectedValue);
                companyComboBox.DataSource = _stockManager.GetCompanyforSearch(itemSummary);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            itemSummary.companyID = Convert.ToInt32(companyComboBox.SelectedValue);
            itemSummary.categoryID = Convert.ToInt32(categoryComboBox.SelectedValue);                 
                    
            displayItemSummary.DataSource = _stockManager.SearchItem(itemSummary);
            
        }

        private void displayItemSummary_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            displayItemSummary.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
