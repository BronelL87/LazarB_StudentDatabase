using LazarB_StudentDatabase.Data;
using LazarB_StudentDatabase.Models;

namespace LazarB_StudentDatabase.Services.Students;

    public class SdntServices : ISdntServices
    {
    private readonly MyData _db;

    public SdntServices(MyData db)
    {
        _db = db;
    }

    public List<Student> AddStudent(string firstN, string lastN, string hobby)
    {
        Student newStudent = new();

        newStudent.FirstN = firstN;

        newStudent.LastN = lastN;

        newStudent.Hobby = hobby;

        _db.Students.Add(newStudent);
        _db.SaveChanges();

        return _db.Students.ToList();
    }

    public List<Student> DeleteStudent(string firstN)
    {
        var foundStudent = _db.Students.FirstOrDefault(Student => Student.FirstN == firstN);
        if(foundStudent != null){
            _db.Students.Remove(foundStudent);
            _db.SaveChanges();
        }
        return _db.Students.ToList();
    }

   

    public List<Student> GetStudents()
    {
        return _db.Students.ToList();
    }

    
}

