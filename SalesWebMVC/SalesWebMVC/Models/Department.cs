using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public Department()
        {
            this.Sellers = new List<Seller>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }


        public void AddSeller(Seller seller)
        {
            this.Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return this.Sellers.Sum(seller => seller.TotalSales(initial, final));            
        }

    }
}
