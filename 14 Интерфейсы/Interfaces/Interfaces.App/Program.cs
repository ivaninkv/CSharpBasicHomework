namespace Interfaces.App;

internal class Program
{
    public static void Main(string[] args)
    {
        var quadcopter = new Quadcopter();

        Console.WriteLine("======== Quadcopter ========");
        quadcopter.Charge();
        Console.WriteLine(string.Join(", ", quadcopter.GetComponents().ToArray()));
        Console.WriteLine();

        Console.WriteLine("======== IChargeable ========");
        ((IChargeable)quadcopter).Charge();
        Console.WriteLine(((IChargeable)quadcopter).GetInfo());
        Console.WriteLine();

        Console.WriteLine("======== IFlyingRobot ========");
        Console.WriteLine(((IFlyingRobot)quadcopter).GetRobotType());
        Console.WriteLine(string.Join(", ", ((IFlyingRobot)quadcopter).GetComponents().ToArray()));
        Console.WriteLine(((IFlyingRobot)quadcopter).GetInfo());
        Console.WriteLine();

        Console.WriteLine("======== IRobot ========");
        Console.WriteLine(((IRobot)quadcopter).GetRobotType());
        Console.WriteLine(string.Join(", ", ((IRobot)quadcopter).GetComponents().ToArray()));
        Console.WriteLine(((IRobot)quadcopter).GetInfo());
        Console.WriteLine();
    }
}
