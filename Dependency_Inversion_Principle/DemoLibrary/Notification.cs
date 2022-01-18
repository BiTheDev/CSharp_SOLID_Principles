using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class Notification : IMessageSender
    {


        public void SendMessage(IStudent student, ISchoolCourse course)
        {
            Console.WriteLine($"Hello {student.FirstName} {student.LastName}, you have registered to {course.CourseName}, instruct by {course.Instructor.FirstName}");
        }
    }
}
