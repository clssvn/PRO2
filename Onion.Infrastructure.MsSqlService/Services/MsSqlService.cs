using Onion.Domain.Entities;
using Onion.Domain.Services;
using Onion.Infrastructure.MsSqlService.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Onion.Infrastructure.MsSqlService.Services
{
    public class MsSqlService : IStudentDbService
    {
        public bool EnrollStudent(Student newStudent, int semestr)
        {
            using (var context = new StudentContext())
            {
                context.Students.Add(newStudent);
                context.SaveChanges();

                return true;
            }
        }

        public IEnumerable<Student> GetStudents()
        {
            using (var context = new StudentContext())
            {
                return context.Students.ToList<Student>();
            }
        }
    }
}


