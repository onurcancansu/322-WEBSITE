using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MYRESTAURANT.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }
        
        //public int ProductQuantity { get; set; }
        public int ProductPrice { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string ProductImage { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string Categoryname { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Sale> Sales { get; set; }
        
    }
}