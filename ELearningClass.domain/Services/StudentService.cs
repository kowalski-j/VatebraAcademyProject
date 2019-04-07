using ELearningClass.domain.ApiResponseModels;
using ELearningClass.domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELearningClass.domain.Services
{
    class StudentService : IStudentService
    {
        public StudentService(ELearningDataContext dataContext)
        {

        }
        public ICollection<GetStudentResponse> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public GetStudentResponse GetStudent(string matricNumber)
        {
            throw new NotImplementedException();
        }
    }
}
