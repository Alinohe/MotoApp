namespace MotoApp.Data.Entities
{
    public class Employee : EntityBase
    {
        public Employee()
        {

        }
        public Employee(string name)
        {

        }
        public Employee(string firstName, string lastName)
        {

        }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public override string ToString() => $"ID: {Id}, FirstName: {FirstName}, LastName: {LastName}";

    }
}
