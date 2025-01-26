
public class ItemAdded
{
    public Action<object> employeeAdded;

    public ItemAdded(Action<object> employeeAdded)
    {
        this.employeeAdded = employeeAdded;
    }
}