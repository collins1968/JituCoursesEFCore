using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JituCourses.Models
{
    public class CoursesDTO
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        
        public string CourseDescription { get; set; }

        public string price { get; set; } = string.Empty;
    }
}
