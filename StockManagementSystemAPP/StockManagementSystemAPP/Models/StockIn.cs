using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemAPP.Models
{
    class StockIn
    {

        public int ID { get; set; }
        public int item_ID { get; set; }
        public int available_quantity { get; set; }
        public int stockin_quantity { get; set; }
        public string Date { get; set; }

        public string Item { get; set; }
        public int oldItem_ID;


    }
}
