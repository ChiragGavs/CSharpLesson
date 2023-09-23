using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCEFwebApp.Models
{
    public class Patient
    {
        [Key]
        [Column("Patientno")]
        public int PID { get; set; }

        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "must be btw 3 nd 20 ")]
        public string Name { get; set; } = string.Empty;
        [Required]

        public string City { get; set; } = String.Empty;
        public DateTime PDOB { get; set; }
        [Column(TypeName ="numeric(18,0)")]
        public long PhoneNumber { get; set; }
    }

}
