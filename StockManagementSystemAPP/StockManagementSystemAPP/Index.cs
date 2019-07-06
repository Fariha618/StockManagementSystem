using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemAPP
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

     

        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupCategory setupCategory=new SetupCategory();

            setupCategory.Show();
        }

        private void companySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupCompany setupCompany=new SetupCompany();
            setupCompany.Show();
        }

        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupItem setupItem=new SetupItem();
            setupItem.Show();
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockInUi stockInUi=new StockInUi();
            stockInUi.Show();
        }

        private void seachAndViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSummaryUi itemSummaryUi=new ItemSummaryUi();
            itemSummaryUi.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports=new Reports();
            reports.Show();
        }
    }
}
