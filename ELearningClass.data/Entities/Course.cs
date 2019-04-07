using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ELearningClass.data.Entities
{
    public class Course : BaseEntity
    {
       
        [Required]
        [StringLength(50)]
        public string CourseTitle { get; set; }

        [Required]
        [StringLength(50)]
        public string CourseCode { get; set; }

        public string CourseDescription { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        public Course()
        {
            Enrollments = new Collection<Enrollment>();
        }
       

        
    }
}
