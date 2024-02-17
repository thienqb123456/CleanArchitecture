using System.Runtime.Serialization;

namespace Application.Exceptions;

[Serializable]
public class RepositoryException : InfrastructureException
{
    public RepositoryException()
    {
    }

    public RepositoryException(string message) : base(message)
    {
    }

    public RepositoryException(Exception inner) : base("", inner)
    {
    }

    public RepositoryException(string message, Exception inner) : base(message, inner)
    {
    }

    protected RepositoryException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}