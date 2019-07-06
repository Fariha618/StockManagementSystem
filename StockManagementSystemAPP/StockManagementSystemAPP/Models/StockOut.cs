using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemAPP.Models
{
   public  class StockOut
    {
        public int ID { get; set; }
        public int item_ID { get; set; }
        public int stockout_quantity { get; set; }
        public int stockout_type { get; set; }

        
        public string company { get; set; }
        public string Item { get; set; }

    }
}
