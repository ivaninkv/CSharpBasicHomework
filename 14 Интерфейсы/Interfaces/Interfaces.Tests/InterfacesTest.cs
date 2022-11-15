using Interfaces.App;

namespace Interfaces.Tests;

public class InterfacesTest
{
    private static readonly Quadcopter Quadcopter = new();
    private readonly IChargeable _chargeable = Quadcopter;
    private readonly List<string> _components = new() { "rotor1", "rotor2", "rotor3", "rotor4" };
    private readonly IFlyingRobot _flyingRobot = Quadcopter;
    private readonly IRobot _robot = Quadcopter;

    [Fact]
    public void RobotTest()
    {
        Assert.Equal("I am a simple robot.", _robot.GetRobotType());
        Assert.Equal("I am IRobot from Quadcopter", _robot.GetInfo());
        Assert.Equal(_components, _robot.GetComponents());
    }

    [Fact]
    public void FlyingRobotTest()
    {
        Assert.Equal("I am a flying robot.", _flyingRobot.GetRobotType());
        Assert.Equal("I am IRobot from Quadcopter", _flyingRobot.GetInfo());
        Assert.Equal(_components, _flyingRobot.GetComponents());
    }

    [Fact]
    public void ChargeableTest()
    {
        Assert.Equal("I am IChargeable from Quadcopter", _chargeable.GetInfo());
    }

    [Fact]
    public void QuadcopterTest()
    {
        Assert.Equal(_components, Quadcopter.GetComponents());
    }
}
