using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Client
    {
        [Key]
        public string NIF { get; set; }
        public string Nom { get; set; }
        public string Cognom { get; set; }

        [Display(Name = "DataNaixement")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNaixement { get; set; }
        public string Carrer { get; set; }
        public string Numero { get; set; }
        public string Poblacio { get; set; }
        public string Provincia { get; set; }
        public int CP { get; set; }
        public int Tlf { get; set; }
        public string Correu { get; set; }
        public string Aut { get; set; }
    }

   
    
}