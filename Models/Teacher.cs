using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebLast_MVC_.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }


        [MaxLength(50)]
        [MinLength(5)]
        public string TeacherName { get; set; }

        [Range(18, 50)]
        public int TeacherAge { get; set; }
    }
}
