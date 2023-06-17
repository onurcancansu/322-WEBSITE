using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MYRESTAURANT.Models.Classes
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string PersonelName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string PersonelImage { get; set; }
        //public int PersonelStar { get; set; }
        public ICollection<Sale> Sales { get; set; }

    }
}