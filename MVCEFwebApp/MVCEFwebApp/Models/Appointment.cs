using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVCEFwebApp.Models;

namespace MVCEFwebApp.Models
{
    public class Appointment
    {
        [Key]
        [Column("Appointmentno")]
        public int ID { get; set; }
        
        [Required]
        [ForeignKey("Patient")]
        public int PID { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DocID { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}
