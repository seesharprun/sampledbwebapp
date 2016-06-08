using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDBWebApp.Models
{
    public class SchoolContextInitializer : CreateDatabaseIfNotExists<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            base.Seed(context);

            List<Student> students = new List<Student> {
                new Student
                {
                    FirstName = "Buckley",
                    LastName = "Stone",
                    Age = 5,
                    Teacher = "Mcleod"
                },
                new Student
                {
                    FirstName = "Emma",
                    LastName = "Armstrong",
                    Age = 7,
                    Teacher = "Hobbs"
                },
                new Student
                {
                    FirstName = "Dawson",
                    LastName = "Nunez",
                    Age = 9,
                    Teacher = "French"
                },
                new Student
                {
                    FirstName = "Padilla",
                    LastName = "Knowles",
                    Age = 7,
                    Teacher = "Marquez"
                },
                new Student
                {
                    FirstName = "Lupe",
                    LastName = "Vasquez",
                    Age = 9,
                    Teacher = "Osborn"
                },
                new Student
                {
                    FirstName = "Sofia",
                    LastName = "Delaney",
                    Age = 10,
                    Teacher = "Simpson"
                },
                new Student
                {
                    FirstName = "Hopkins",
                    LastName = "Delacruz",
                    Age = 9,
                    Teacher = "Puckett"
                }
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
