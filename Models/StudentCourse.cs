using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebLast_MVC_.Models
{
    public class StudentCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentCourseID { get; set; }

        //here StudentID forign key
        public int StudentID { get; set; }
        public Student Student { get; set; }

        //here CourseID forign key
        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
