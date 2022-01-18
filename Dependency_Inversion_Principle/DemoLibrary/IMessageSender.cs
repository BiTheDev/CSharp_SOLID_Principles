namespace DemoLibrary
{
    public interface IMessageSender
    {
        void SendMessage(IStudent student, ISchoolCourse course);
    }
}