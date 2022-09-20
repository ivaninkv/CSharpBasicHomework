namespace Interfaces.App;

internal class Program
{
    public static void Main(string[] args)
    {
        var quadcopter = new Quadcopter();
        IFlyingRobot flyingRobot = quadcopter;
        IChargeable chargeable = quadcopter;
        IRobot robot = quadcopter;

        Console.WriteLine("======== Quadcopter ========");
        quadcopter.Charge();
        Console.WriteLine(string.Join(", ", quadcopter.GetComponents().ToArray()));
        Console.WriteLine();

        Console.WriteLine("======== IChargeable ========");
        chargeable.Charge();
        Console.WriteLine(chargeable.GetInfo());
        Console.WriteLine();

        Console.WriteLine("======== IFlyingRobot ========");
        Console.WriteLine(flyingRobot.GetRobotType());
        Console.WriteLine(string.Join(", ", flyingRobot.GetComponents().ToArray()));
        Console.WriteLine(flyingRobot.GetInfo());
        Console.WriteLine();

        Console.WriteLine("======== IRobot ========");
        Console.WriteLine(robot.GetRobotType());
        Console.WriteLine(string.Join(", ", robot.GetComponents().ToArray()));
        Console.WriteLine(robot.GetInfo());
        Console.WriteLine();
    }
}
