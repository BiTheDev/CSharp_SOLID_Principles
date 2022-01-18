using System;
using DemoLibrary;
namespace DIPDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IStudent student = Factory.CreateStudent();

            student.FirstName = "John";
            student.LastName = "Doe";
            student.Email = "JD@Email.edu";
            student.Phone = 5555555555;

            IInstructor instructor = Factory.CreateInstructor();

            instructor.FirstName = "Henry";
            instructor.LastName = "Jackson";
            instructor.Phone = 9999999999;
            instructor.Email = "HenryJ@Email.edu";
            
            ISchoolCourse course = Factory.CreateSchoolCourse();
            course.CourseName = "Design Pattern 101";
            course.CourseID = 4453;
            course.Instructor = instructor;
            course.Description = "Learning SOLID Design Pattern";
            

            course.Register(student);

            IMessageSender messageSender = Factory.CreateNotification();

            messageSender.SendMessage(student, course);
        }
    }
}
