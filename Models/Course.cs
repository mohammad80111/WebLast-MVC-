using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebLast_MVC_.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseID { get; set; }

        [MinLength(5)]
        [MaxLength(50)]
        public string CourseName { get; set; }


        //here teacherID forign key
        public int TeacherId { get; set; }
        public Teacher teacher { get; set; }

        [Range(1, 20)]
        public int CourseCapacity { get; set; }
    }
}
