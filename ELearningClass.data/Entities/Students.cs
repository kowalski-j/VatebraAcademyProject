using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ELearningClass.data.Entities
{
    public class Student: BaseEntity
    {

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }


        [Required]
        [StringLength(20)]
        public string LastName { get; set; }


        [Required]
        [StringLength(11)]
        public string MatricNumber { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        public Student()
        {
            Enrollments = new Collection<Enrollment>();
        }
    }
}
