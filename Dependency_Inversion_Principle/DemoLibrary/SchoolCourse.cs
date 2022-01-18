using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class SchoolCourse : ISchoolCourse
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public IInstructor Instructor { get; set; }

        public List<IStudent> Students { get; set; } = new List<IStudent>();

        public void Register(IStudent student)
        {
            Students.Add(student);
        }
        

    }
}
