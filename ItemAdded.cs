
internal class ItemAdded
{
    private Action<object> employeeAdded;

    public ItemAdded(Action<object> employeeAdded)
    {
        this.employeeAdded = employeeAdded;
    }
}