using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class EmailMessage : IMessageSender
    {
        public void SendMessage(IStudent student, ISchoolCourse course)
        {
            Console.WriteLine("Subject: Course Registration");
            Console.WriteLine($"Dear {student.FirstName}, you have successfully registered to the {course.CourseID} {course.CourseName}. Instruct by {course.Instructor.FirstName} {course.Instructor.LastName}.");
        }
    }
}
