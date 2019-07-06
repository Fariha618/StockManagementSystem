using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemAPP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SetupCategory());
            Application.Run(new SetupCompany());
            //Application.Run(new SetupItem());
<<<<<<< HEAD
            //Application.Run(new StockInUi());
            //Application.Run(new StockOutUi());
            //Application.Run(new ItemSummaryUi());
=======
            Application.Run(new StockInUi());
            //Application.Run(new StockOutUi());
            Application.Run(new ItemSummaryUi());
>>>>>>> f5abf30f030910cda321dcff1b04527791dfae0b
        }
    }
}
