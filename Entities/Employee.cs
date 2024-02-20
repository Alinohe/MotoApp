namespace MotoApp.Entities
{
    public class Employee : EntityBase
    {
        public Employee()
        {

        }
        public Employee(string name) 
        {
        
        }
        public string? FirstName { get; set; }

        public override string ToString() => $"ID: {Id}, FirstName: {FirstName}";
        
     }
}
