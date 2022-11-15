namespace Trees.App;

public static class Program
{
    private static EmployeeNode? _root;
    private static int _userChoice;

    public static void Main(string[] args)
    {
        while (true)
        {
            if (_userChoice == 0)
            {
                _root = null;
                InputEmployees();
                Traverse(_root);
            }

            var salary = InputSalaryForSearch();
            var foundNode = FindNodeBySalary(_root, salary);
            if (foundNode != null)
            {
                Console.WriteLine(foundNode);
            }
            else
            {
                Console.WriteLine("Такой сотрудник не найден");
            }

            _userChoice = InputUserChoice();
        }
    }

    private static int InputUserChoice()
    {
        string choice;
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("0 - переход к началу программы");
            Console.WriteLine("1 - поиск зарплаты");

            choice = Console.ReadLine()?.Trim() ?? "";
            if (choice is "0" or "1")
                break;
        }

        return int.Parse(choice);
    }

    private static EmployeeNode? FindNodeBySalary(EmployeeNode? root, int salary)
    {
        if (salary < root?.Salary)
        {
            return root.LeftNode != null ? FindNodeBySalary(root.LeftNode, salary) : null;
        }

        if (salary > root?.Salary)
        {
            return root.RightNode != null ? FindNodeBySalary(root.RightNode, salary) : null;
        }

        return root;
    }

    private static int InputSalaryForSearch()
    {
        Console.WriteLine("Введите зарплату для поиска: ");
        var salary = Console.ReadLine() ?? "";
        return int.Parse(salary);
    }

    private static void Traverse(EmployeeNode? root)
    {
        if (root?.LeftNode != null)
        {
            Traverse(root.LeftNode);
        }

        Console.WriteLine(root);

        if (root?.RightNode != null)
        {
            Traverse(root.RightNode);
        }
    }

    private static void InputEmployees()
    {
        while (true)
        {
            var name = Console.ReadLine() ?? "";
            if (name == string.Empty)
            {
                break;
            }


            int salary;
            while (!int.TryParse(Console.ReadLine() ?? "", out salary))
            {
                Console.WriteLine("Введите целое число");
            }

            if (_root == null)
            {
                _root = new EmployeeNode(name, salary);
            }
            else
            {
                AddNode(_root, new EmployeeNode(name, salary));
            }
        }
    }

    private static void AddNode(EmployeeNode root, EmployeeNode employeeNode)
    {
        if (employeeNode.Salary < root.Salary)
        {
            if (root.LeftNode != null)
            {
                AddNode(root.LeftNode, employeeNode);
            }
            else
            {
                root.LeftNode = employeeNode;
            }
        }
        else
        {
            if (root.RightNode != null)
            {
                AddNode(root.RightNode, employeeNode);
            }
            else
            {
                root.RightNode = employeeNode;
            }
        }
    }
}
