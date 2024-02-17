using System.Runtime.Serialization;

namespace Application.Exceptions;

[Serializable]
public class BaseEntityException : InfrastructureException
{
    public BaseEntityException()
    {
    }

    public BaseEntityException(string message) : base(message)
    {
    }

    public BaseEntityException(Exception inner) : base("", inner)
    {
    }

    public BaseEntityException(string message, Exception inner) : base(message, inner)
    {
    }

    protected BaseEntityException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}