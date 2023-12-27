using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public Seller()
        {
            this.Sales = new List<SalesRecord>();
        }

        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<SalesRecord> Sales{ get; set; }

        public void AddSales(SalesRecord sr)
        {
            this.Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            this.Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return this.Sales.Where(s => s.Date >= initial && s.Date <= final).Sum(v => v.Amount);
             
        }

    }

}
