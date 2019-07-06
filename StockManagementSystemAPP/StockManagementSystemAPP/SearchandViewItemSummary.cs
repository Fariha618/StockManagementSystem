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
    public partial class SearchandViewItemSummary : Form
    {
        public SearchandViewItemSummary()
        {
            InitializeComponent();
        }

        StockManager _stockManager = new StockManager();

        private void SearchandViewItemSummary_Load(object sender, EventArgs e)
        {
            companyComboBox.DataSource = _stockManager.LoadCompany();
            categoryComboBox.DataSource = _stockManager.LoadCategory();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
