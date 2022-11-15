namespace Trees.App;

public class EmployeeNode
{
    public EmployeeNode(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{Name} - {Salary}";
    }

    public string Name { get; set; }
    public int Salary { get; set; }
    public EmployeeNode? LeftNode { get; set; }
    public EmployeeNode? RightNode { get; set; }

}
