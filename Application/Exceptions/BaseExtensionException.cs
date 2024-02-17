using System.Runtime.Serialization;

namespace Application.Exceptions;

[Serializable]
public class BaseExtensionException : InfrastructureException
{
    public BaseExtensionException()
    {
    }

    public BaseExtensionException(string message) : base(message)
    {
    }

    public BaseExtensionException(Exception inner) : base("", inner)
    {
    }

    public BaseExtensionException(string message, Exception inner) : base(message, inner)
    {
    }

    protected BaseExtensionException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}