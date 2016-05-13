using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaMarketing.Models
{
    public class StandViewModel
    {
        public int Id { get; set; }
        [Required]
        public String Descripcion { get; set; }
        [Required]
        public String Tamano { get; set; }
        [Required]
        public String Plano { get; set; }
        [Required]
        public SelectList Campaña { get; set; }

        public SelectList Cliente { get; set; }
        
    }
}