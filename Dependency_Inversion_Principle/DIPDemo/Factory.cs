using System;
using System.Collections.Generic;
using System.Text;
using DemoLibrary;
namespace DIPDemo
{
    public class Factory
    {

        public static IStudent CreateStudent()
        {
            return new Student();
        }

        public static ISchoolCourse CreateSchoolCourse()
        {
            return new SchoolCourse();
        }

        public static IInstructor CreateInstructor()
        {
            return new Instructor();
        }


        public static IMessageSender CreateNotification()
        {
            return new Notification();
        }
    }
}
