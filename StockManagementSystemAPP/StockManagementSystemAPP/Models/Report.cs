using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemAPP.Models
{
    class Report
    {
        public string Item { get; set; }
        public string Company { get; set; }
        public string Quantity { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public int action { get; set; }

    }
}
