using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazarB_StudentDatabase.Models;

namespace LazarB_StudentDatabase.Services.Students
{
    public interface ISdntServices
    {
        List<Student> GetStudents();

        List<Student> AddStudent(string FirstN, string LastN, string Hobby);
        List<Student> DeleteStudent(string FirstN);


    }
}