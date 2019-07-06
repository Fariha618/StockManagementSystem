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
    public partial class SetupItem : Form
    {
        StockManager _stockManager = new StockManager();
        private Item item;

        public SetupItem()
        {
            InitializeComponent();
            item = new Item();
        }

        private void SetupItem_Load(object sender, EventArgs e)
        {
            companyComboBox.DataSource = _stockManager.LoadCompany();
            categoryComboBox.DataSource = _stockManager.LoadCategory();
            displayItem.DataSource = _stockManager.ShowItem();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveButton.Text == "Update")
                {
                    item.company_ID = Convert.ToInt32(companyComboBox.SelectedValue);
                    item.category_ID = Convert.ToInt32(categoryComboBox.SelectedValue);
                    item.Name = nameTextBox.Text;

                    if (String.IsNullOrEmpty(nameTextBox.Text))
                    {
                        errorLabel.Text = "Name Field is Empty!";
                        return;
                    }

                    errorLabel.Text = " ";

                    if (_stockManager.IsExistItem(nameTextBox.Text))
                    {
                        MessageBox.Show("Item Already Exist!");
                        nameTextBox.Clear();
                        reorderLevelTextBox.Clear();
                        return;
                    }


                    if (String.IsNullOrEmpty(reorderLevelTextBox.Text))
                    {
                        reorderLabel.Text = "Reorder Level Field is Empty!";
                        return;
                    }
                    reorderLabel.Text = " ";


                    if (System.Text.RegularExpressions.Regex.IsMatch(reorderLevelTextBox.Text, "[^0-9]"))
                    {
                        reorderLabel.Text = "Enter Only Digits";
                        return;
                    }
                    reorderLabel.Text = "";

                    item.reorder_level = Convert.ToInt32(reorderLevelTextBox.Text);

                    int i;
                    i = displayItem.SelectedCells[0].RowIndex;
                    item.oldName = displayItem.Rows[i].Cells[1].Value.ToString();


                    int isExecuted;
                    isExecuted = _stockManager.UpdateItem(item);

                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Updated");
                    }
                    else
                    {
                        MessageBox.Show("Not Updated");
                    }

                    nameTextBox.Clear();
                    reorderLevelTextBox.Clear();
                    SaveButton.Text = "Save";
                }

                else if (SaveButton.Text == "Save")
                {
                    item.company_ID = Convert.ToInt32(companyComboBox.SelectedValue);
                    item.category_ID = Convert.ToInt32(categoryComboBox.SelectedValue);

                    item.Name = nameTextBox.Text;

                    if (String.IsNullOrEmpty(nameTextBox.Text))
                    {
                        errorLabel.Text = "Name Field is Empty!";
                        return;
                    }

                    errorLabel.Text = " ";

                    if (_stockManager.IsExistItem(nameTextBox.Text))
                    {
                        MessageBox.Show("Item Already Exist!");
                        nameTextBox.Clear();
                        reorderLevelTextBox.Clear();
                        return;
                    }


                    if (String.IsNullOrEmpty(reorderLevelTextBox.Text))
                    {
                        reorderLabel.Text = "Reorder Level Field is Empty!";
                        return;
                    }
                    reorderLabel.Text = " ";


                    if (System.Text.RegularExpressions.Regex.IsMatch(reorderLevelTextBox.Text, "[^0-9]"))
                    {
                        reorderLabel.Text = "Enter Only Digits";
                        return;
                    }
                    reorderLabel.Text = "";

                    item.reorder_level = Convert.ToInt32(reorderLevelTextBox.Text);


                    int isExecuted;
                    isExecuted = _stockManager.InsertItem(item);

                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Saved");
                    }
                    else
                    {
                        MessageBox.Show("Not Saved");
                    }
                }

                displayItem.DataSource = _stockManager.ShowItem();
            }

            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            }


        private void displayItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (displayItem.SelectedRows.Count > 0)
            {
                nameTextBox.Text = displayItem.SelectedRows[0].Cells[1].Value.ToString();
                companyComboBox.Text = displayItem.SelectedRows[0].Cells[2].Value.ToString();
                categoryComboBox.Text = displayItem.SelectedRows[0].Cells[3].Value.ToString();
                reorderLevelTextBox.Text = displayItem.SelectedRows[0].Cells[4].Value.ToString();
            }

            if (displayItem.SelectedCells.Count > 0)
            {
                int i;
                i = displayItem.SelectedCells[0].RowIndex;
                nameTextBox.Text = displayItem.Rows[i].Cells[1].Value.ToString();
                companyComboBox.Text = displayItem.Rows[i].Cells[2].Value.ToString();
                categoryComboBox.Text = displayItem.Rows[i].Cells[3].Value.ToString();
                reorderLevelTextBox.Text = displayItem.Rows[i].Cells[4].Value.ToString();

            }

            SaveButton.Text = "Update";
        }

        private void displayItem_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            displayItem.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
