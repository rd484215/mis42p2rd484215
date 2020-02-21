using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mis42p2rd484215.Models
{
    public class Vett
    {
        public int vettID { get; set; }

        [Display(Name = "Vet Last Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        public string vetLastName { get; set; }

        [Display(Name = "Vet First Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        public string vetFirstName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Required")]
        public string email { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Required")]
        public string phone { get; set; }
    }
}