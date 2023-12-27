using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesWebMVC.Models.Enums.SaleStatus Status { get; set; }
        public virtual Seller Seller { get; set; }
    }
}
