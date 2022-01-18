using System.Collections.Generic;

namespace DemoLibrary
{
    public interface ISchoolCourse
    {
        int CourseID { get; set; }
        string CourseName { get; set; }
        string Description { get; set; }
        IInstructor Instructor { get; set; }
        List<IStudent> Students { get; set; }
        void Register(IStudent student);
    }
}