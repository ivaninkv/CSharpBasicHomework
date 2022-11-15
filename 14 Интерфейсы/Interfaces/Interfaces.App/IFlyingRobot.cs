namespace Interfaces.App;

public interface IFlyingRobot : IRobot
{
    public new string GetRobotType()
    {
        return "I am a flying robot.";
    }
}
