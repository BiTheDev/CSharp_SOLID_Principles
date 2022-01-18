namespace OCPDemo
{
    public interface IPersonModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        IAccounts AccountCreation { get; set; }
    }
}