using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirthWebApplication.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10, ErrorMessage = "May khong duoc viet qua 20 ky tu")]
        public string LastName { get; set; }
        [StringLength(10, ErrorMessage = "May khong duoc viet qua 20 ky tu")]
        [Column("First Name")]
        [Required]
        public string FistMidName { get; set; }
        public string Address { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}",ApplyFormatInEditMode = true)]
        [Display(Name ="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}