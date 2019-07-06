using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemAPP.BLL;
using StockManagementSystemAPP.Models;

namespace StockManagementSystemAPP
{
    public partial class Reports : Form
    {

        DataTable dataTable;
        StockManager _stockManager = new StockManager();
        private Report report;

        public Reports()
        {
            InitializeComponent();
            dataTable = new DataTable();
            report = new Report();
        }

      


        private void SearcButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                report.fromDate = fromDateTimePicker.Value.ToString("dd/mm/yyyy");
                report.toDate = toDateTimePicker.Value.ToString("dd/mm/yyyy");

                if(fromDateTimePicker.Value > toDateTimePicker.Value)
                {
                    MessageBox.Show("Please Input Valid Dates! From Date must be equal or smaller than To Date.");
                    reportLabel.Text = "Please Input Valid Dates!";
                    return;
                }

                reportLabel.Text = "";


                if (soldRadioButton.Checked == true)
                {
                    report.action = 0;
                }
                else if (damagedRadioButton.Checked == true)
                {
                    report.action = 1;
                }
                else
                {
                    report.action = 2;
                }

                dataTable = _stockManager.LoadStockOutToDataGridView(report);
                displayDataGridView.DataSource = dataTable;

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No Data Found");
                }

            }

            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void displayDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            displayDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
