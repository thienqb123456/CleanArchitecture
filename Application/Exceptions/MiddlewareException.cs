using System.Runtime.Serialization;

namespace Application.Exceptions;

[Serializable]
public class MiddlewareException : InfrastructureException
{
    public MiddlewareException()
    {
    }

    public MiddlewareException(string message) : base(message)
    {
    }

    public MiddlewareException(Exception inner) : base("", inner)
    {
    }

    public MiddlewareException(string message, Exception inner) : base(message, inner)
    {
    }

    protected MiddlewareException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}