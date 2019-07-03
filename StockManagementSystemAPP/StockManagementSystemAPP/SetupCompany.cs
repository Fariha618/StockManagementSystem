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
    public partial class SetupCompany : Form
    {
        StockManager _stockManager = new StockManager();
        private Company company;

        public SetupCompany()
        {
            InitializeComponent();
            company = new Company();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveButton.Text == "Update")
            {
                company.Name = nameTextBox.Text;

                int i;
                i = displayCompany.SelectedCells[0].RowIndex;
                company.oldName = displayCompany.Rows[i].Cells[1].Value.ToString();

                int isExecuted;
                isExecuted = _stockManager.UpdateCompany(company);

                if (isExecuted > 0)
                {
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Not Updated");
                }

                nameTextBox.Clear();
                SaveButton.Text = "Save";
            }

            else if (SaveButton.Text == "Save")
            {
                company.Name = nameTextBox.Text;

                int isExecuted;
                isExecuted = _stockManager.InsertCompany(company);

                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }

                nameTextBox.Clear();
            }

            displayCompany.DataSource = _stockManager.ShowCompany();
        }

        private void SetupCompany_Load(object sender, EventArgs e)
        {
            displayCompany.DataSource = _stockManager.ShowCompany();
        }

        private void displayCompany_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (displayCompany.SelectedRows.Count > 0)
            {
                nameTextBox.Text = displayCompany.SelectedRows[0].Cells[1].Value.ToString();
            }

            if (displayCompany.SelectedCells.Count > 0)
            {
                int i;
                i = displayCompany.SelectedCells[0].RowIndex;
                nameTextBox.Text = displayCompany.Rows[i].Cells[1].Value.ToString();

            }

            SaveButton.Text = "Update";
        }

        private void displayCompany_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            displayCompany.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
