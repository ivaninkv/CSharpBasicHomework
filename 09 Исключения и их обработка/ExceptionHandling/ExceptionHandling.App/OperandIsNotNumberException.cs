using System.Runtime.Serialization;

namespace ExceptionHandling.App;

public class OperandIsNotNumberException : Exception
{
    public OperandIsNotNumberException(string number)
    {
        Number = number;
    }

    protected OperandIsNotNumberException(SerializationInfo info, StreamingContext context, string number) : base(info,
        context)
    {
        Number = number;
    }

    public OperandIsNotNumberException(string? message, string number) : base(message)
    {
        Number = number;
    }

    public OperandIsNotNumberException(string? message, Exception? innerException, string number) : base(message,
        innerException)
    {
        Number = number;
    }

    public string Number { get; }
}