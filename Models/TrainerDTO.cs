using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JituCourses.Models
{
    public class TrainerDTO
    {
        [Key]
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        
        public string TrainerEmail { get; set; }
    }
}
