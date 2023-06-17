using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MYRESTAURANT.Models.Classes
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CustomerName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CustomerSurName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CustomerMail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CustomerPassword { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CustomerAdress { get; set; }
        /*
        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string CustomerImage { get; set; }*/
        public ICollection<Sale> Sales { get; set; }
    }
}