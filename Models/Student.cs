using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebLast_MVC_.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }


        [MinLength(5)]
        [MaxLength(50)]
        public string StudentName { get; set; }



        public bool IsActive { get; set; }


        [Range(6, 18)]
        public int StudentAge { get; set; }
    }
}
