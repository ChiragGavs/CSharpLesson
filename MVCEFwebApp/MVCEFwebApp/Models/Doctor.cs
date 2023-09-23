using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCEFwebApp.Models
{
    public class Doctor
    {
        [Key]
        [Column("doctorno")]
        public int DocID { get; set; }

        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage  ="must be btw 3 nd 20 ")]
        public string Name { get; set; }
        [Required]
        public string Speaciality { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,2)")]
        public decimal VisitingFees { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,2)")]
        public long PhoneNumber { get; set; }
    }
}
