namespace Domain
{
    public interface IEmployee
    {
        string name { get; }
        string email { get; }

        string ToString();
    }
}
