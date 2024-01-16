using LazarB_StudentDatabase;
using LazarB_StudentDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace LazarB_StudentDatabase.Data;

    public class MyData : DbContext
    {
        public MyData(DbContextOptions<MyData> options) : base(options)
        {

        }

        public DbSet<Student> Students {get; set;}
    }
