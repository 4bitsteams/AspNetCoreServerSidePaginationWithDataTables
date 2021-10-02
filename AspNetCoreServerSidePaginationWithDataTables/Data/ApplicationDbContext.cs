using DatatablesServerSide.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreServerSidePaginationWithDataTables.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        //StudentList is static to be able to reach in application scope
        public static List<Student> StudentList { get; set; }

        //Creates “studentCount” students and adds into student list
        public static void InitStudentList(int studentCount)
        {
            StudentList = new List<Student>();
            for (int i = 1; i < studentCount + 1; i++)
            {
                StudentList.Add(
                    new Student()
                    {
                        Id = i,
                        Firstname = "Firstname" + i,
                        Lastname = "Lastname" + i,
                        CreatedDate = DateTime.Now
                    }
                );
            }
        }
    }
}
