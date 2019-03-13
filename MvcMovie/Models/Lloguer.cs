using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Lloguer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDlloguer { get; set; }

        [ForeignKey("Copies"), Column(Order = 1)]
        public int IDcopies { get; set; }
        [ForeignKey("Copies"), Column(Order = 2)]
        public int numCopia { get; set; }
        public virtual Copies Copies { get; set; }



        [ForeignKey("Client")]
        public string ClientID { get; set; }


        public virtual Client Client { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy hh:mm}",ApplyFormatInEditMode =true)]
        public DateTime DataInici { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}", ApplyFormatInEditMode = true)]
        public DateTime DataFi { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataReal { get; set; }
        public bool Perdut { get; set; }
        public bool Amortitzat { get; set; }




    }
}