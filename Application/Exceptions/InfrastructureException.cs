using System.Runtime.Serialization;

namespace Application.Exceptions;

[Serializable]
public class InfrastructureException : Exception
{
    public InfrastructureException()
    {
    }

    public InfrastructureException(string message) : base(message)
    {
    }

    public InfrastructureException(Exception inner) : base("", inner)
    {
    }

    public InfrastructureException(string message, Exception inner) : base(message, inner)
    {
    }

    protected InfrastructureException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}