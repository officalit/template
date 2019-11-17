using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_ang.Models
{
    public class BuyProduct
    {
        public int Id { get; set; }
        public int Product_id { get; set; }
        public int Chek_id { get; set; }
        public string Price { get; set; }
    }
}