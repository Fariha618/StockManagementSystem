using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemAPP.Models
{
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int category_ID { get; set; }
        public int company_ID { get; set; }
        public int reorder_level { get; set; }

        public string Company { get; set; }
        public int stockout_type { get; set; }

        public string oldName;
    }
}
