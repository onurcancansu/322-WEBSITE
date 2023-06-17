using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MYRESTAURANT.Models.Classes
{
    public class Bill
    {
        [Key]
        public int BillID { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string BillNO { get; set; }
        public DateTime date { get; set; }
        public DateTime time { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Sender { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Receiver { get; set; }
        public ICollection<BillPoint> BillPoints { get; set; }


    }
}