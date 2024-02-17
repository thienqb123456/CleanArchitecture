using System.Runtime.Serialization;

namespace Application.Exceptions;

[Serializable]
public class ServiceException : InfrastructureException
{
    public ServiceException()
    {
    }

    public ServiceException(string message) : base(message)
    {
    }

    public ServiceException(Exception inner) : base("", inner)
    {
    }

    public ServiceException(string message, Exception inner) : base(message, inner)
    {
    }

    protected ServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}