using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemAPP.Models
{
    class ItemSummary
    {
        public string Item { get; set; }
        public string Company { get; set; }
        public string Category { get; set; }
        public string Available { get; set; }
        public string ReorderLevel { get; set; }
             
        public int companyID;
        public int categoryID;        
        

    }
}
