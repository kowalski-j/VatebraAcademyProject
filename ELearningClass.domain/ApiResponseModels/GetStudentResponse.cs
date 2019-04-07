using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ELearningClass.domain.ApiResponseModels
{
    public class GetStudentResponse
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

        public ICollection<long> Enrollments { get; set }

        public GetStudentResponse()
        {
            Enrollments = new Collection<long>();
        }

    }
}
