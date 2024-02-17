using System.Runtime.Serialization;

namespace Application.Exceptions;

[Serializable]
public class ContextException : InfrastructureException
{
    public ContextException()
    {
    }

    public ContextException(string message) : base(message)
    {
    }

    public ContextException(Exception inner) : base("", inner)
    {
    }

    public ContextException(string message, Exception inner) : base(message, inner)
    {
    }

    protected ContextException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}