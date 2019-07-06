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
    public partial class SetupCategory : Form
    {

        StockManager _stockManager = new StockManager();
        private Category category;

        public SetupCategory()
        {
            InitializeComponent();
            category = new Category();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveButton.Text == "Update")
            {
                category.Name = nameTextBox.Text;

                if (String.IsNullOrEmpty(nameTextBox.Text))
                {
                    errorLabel.Text = "Name Field Can Not Be Empty!";
                    SaveButton.Text = "Save";
                    return;
                    
                }

                errorLabel.Text = "";

                if (_stockManager.IsExistCategory(nameTextBox.Text))
                {
                    errorLabel.Text = "Category Already Exist!";

                    nameTextBox.Focus();
                    nameTextBox.Clear();
                    SaveButton.Text = "Save";
                    return;
                }

                int i;
                i = displayCategory.SelectedCells[0].RowIndex;
                category.oldName = displayCategory.Rows[i].Cells[1].Value.ToString();

                int isExecuted;
                isExecuted = _stockManager.UpdateCategory(category);

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
                category.Name = nameTextBox.Text;

                if (String.IsNullOrEmpty(nameTextBox.Text))
                {
                    errorLabel.Text = "Name Field Can Not Be Empty!";
                    return;
                }

                errorLabel.Text = "";

                if (_stockManager.IsExistCategory(nameTextBox.Text))
                {
                    errorLabel.Text = "Category Already Exist!";                    
                    nameTextBox.Clear();
                    return;
                }

                int isExecuted;
                isExecuted = _stockManager.InsertCategory(category);

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

            displayCategory.DataSource = _stockManager.ShowCategory();
        }

        private void SetupCategory_Load(object sender, EventArgs e)
        {
            displayCategory.DataSource = _stockManager.ShowCategory();
        }

        private void displayCategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (displayCategory.SelectedRows.Count > 0)
            {
                nameTextBox.Text = displayCategory.SelectedRows[1].Cells[0].Value.ToString();
            }

            if (displayCategory.SelectedCells.Count > 0)
            {
                int i;
                i = displayCategory.SelectedCells[0].RowIndex;
                nameTextBox.Text = displayCategory.Rows[i].Cells[1].Value.ToString();

            }

            SaveButton.Text = "Update";
        }

        private void displayCategory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            displayCategory.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
