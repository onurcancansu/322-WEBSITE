using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MYRESTAURANT.Models.Classes
{
    public class Sale
    {
        [Key]
        public int SalesId { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public Personel Personel { get; set; }

    }
}