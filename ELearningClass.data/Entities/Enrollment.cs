using System;
using System.Collections.Generic;
using System.Text;

namespace ELearningClass.data.Entities
{
    public class Enrollment : BaseEntity
    {
        public long CourseId { get; set; }
        public long StudentId { get; set; }
        public Course Course { get; set; } 
        public Student Student { get; set; }
    }
}
