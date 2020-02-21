using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace mis42p2rd484215.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }

        [Display(Name = "Start Time")]
        [Required(ErrorMessage = "Time Required")]
        public DateTime appointmentStart { get; set; }

        [Display(Name = "End Time")]
        [Required(ErrorMessage = "Time Required")]
        public DateTime appointmentStop { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Required")]
        public int price { get; set; }
        

        // the next two properties link the orderDetail to the Order
        public int pettsID { get; set; }
        public virtual Petts Petts { get; set; }
        // the next two properties link the orderDetail to the Product
        public int vettID { get; set; }
        public virtual Vett Vett { get; set; }
    }
}