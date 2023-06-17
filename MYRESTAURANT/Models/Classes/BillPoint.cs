using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MYRESTAURANT.Models.Classes
{
    public class BillPoint
    {
        [Key]
        public int BillPointsID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Explanation { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public Bill Bill { get; set; }
    }
}