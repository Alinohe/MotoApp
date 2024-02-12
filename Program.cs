var stack = new Stack<double>();
stack.Push(item: 4.5);
stack.Push(item: 43);
stack.Push(item: 333.6);

var stackString = new Stack<string>();
stackString.Push(item: "Client A");
stackString.Push(item: "Client B");
stackString.Push(item: "Client C");
stackString.Push(item: "Client D");

double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}

Console.WriteLine($"Sum: {sum}");

while (stackString.Count > 0)
{
    string item = stackString.Pop();
    Console.WriteLine($"Item: {item}");
}