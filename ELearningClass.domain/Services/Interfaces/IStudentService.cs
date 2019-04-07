using ELearningClass.domain.ApiResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ELearningClass.domain.Services.Interfaces
{
    interface IStudentService
    {
        ICollection<GetStudentResponse> GetAllStudents();
        GetStudentResponse GetStudent(string matricNumber);
    }
}
