using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mis42p2rd484215.Models
{
    public class Petts
    {
        public int pettsID { get; set; }

        [Display(Name = "Pet Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        public string petName { get; set; }

        [Display(Name = "Pet Name")]
        [Required(ErrorMessage = "Required")]
        public string petType { get; set; }

        [Display(Name = "Owner Last Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        public string ownerLastName { get; set; }

        [Display(Name = "Owner First Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        public string ownerFirstName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Required")]
        public string email { get; set; }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Required")]
        public string phone { get; set; }

        [Display(Name = "Patient Since")]
        [Required(ErrorMessage = "Required")]
        public DateTime patientSince { get; set; }
    }
}