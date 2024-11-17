using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.Models
{
    public partial class Item
    {
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? ItemDescription { get; set; }
        public int NumberOnHand { get; set; }
        public int NumberOnOrder { get; set; }
    }
}
