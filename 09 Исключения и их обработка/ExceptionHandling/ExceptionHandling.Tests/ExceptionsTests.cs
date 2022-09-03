using ExceptionHandling.App;

namespace ExceptionHandling.Tests;

public class ExceptionsTests
{
    [Fact(Skip = "Пропущено, потому что исключения обрабатываются в методе ParseInputString")]
    public void CustomExceptionsTest()
    {
        Assert.Throws<MissingOperatorException>(() => Program.ParseInputString("10 4"));
        Assert.Throws<UnknownOperatorException>(() => Program.ParseInputString("10 % 4"));
        Assert.Throws<IncorrectUserInputException>(() => Program.ParseInputString("1 2 3 4"));
        Assert.Throws<IncorrectUserInputException>(() => Program.ParseInputString("10 +"));
        Assert.Throws<OperandIsNotNumberException>(() => Program.ParseInputString("13c4 + 5"));
    }
}