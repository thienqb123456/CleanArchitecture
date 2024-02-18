using Application.IRepositories;

namespace Application.Services;

public class BaseService<T>(ILogger<BaseService<T>> logger, IBaseRepository<T> repository) : IBaseService<T> where T : class, new()
{
    public int Create(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Create(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entity, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Create(T entity, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Create(entity, returning, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entity, returning, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Create(T entity, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Create(entity, returning, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entity, returning, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Create(T entity, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Create(entity, returning, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entity, returning, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateAsync(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entity, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateAsync(T entity, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateAsync(entity, returning, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entity, returning, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateAsync(T entity, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateAsync(entity, returning, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entity, returning, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateAsync(T entity, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateAsync(entity, returning, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entity, returning, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Create(T entity, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Create(entity, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entity, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Create(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Create(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entity, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Create(T entity, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Create(entity, returning, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entity, returning, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Create(T entity, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Create(entity, returning, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entity, returning, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Create(T entity, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Create(entity, returning, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entity, returning, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> CreateAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.CreateAsync(entity, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entity, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> CreateAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.CreateAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entity, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> CreateAsync(T entity, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.CreateAsync(entity, returning, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entity, returning, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> CreateAsync(T entity, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.CreateAsync(entity, returning, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entity, returning, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> CreateAsync(T entity, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.CreateAsync(entity, returning, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entity, returning, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Create(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Create(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entities, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Create(IEnumerable<T> entities, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Create(entities, returning, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entities, returning, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Create(IEnumerable<T> entities, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Create(entities, returning, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entities, returning, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Create(IEnumerable<T> entities, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Create(entities, returning, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entities, returning, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateAsync(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entities, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateAsync(IEnumerable<T> entities, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateAsync(entities, returning, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entities, returning, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateAsync(IEnumerable<T> entities, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateAsync(entities, returning, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entities, returning, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateAsync(IEnumerable<T> entities, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateAsync(entities, returning, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entities, returning, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Create(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Create(entities, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entities, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Create(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Create(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entities, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Create(IEnumerable<T> entities, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Create(entities, returning, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entities, returning, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Create(IEnumerable<T> entities, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Create(entities, returning, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entities, returning, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Create(IEnumerable<T> entities, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Create(entities, returning, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create", entities, returning, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateAsync(entities, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entities, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entities, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateAsync(entities, returning, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entities, returning, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateAsync(entities, returning, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entities, returning, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateAsync(entities, returning, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync", entities, returning, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Create_(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Create_(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create_", entities, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Create_(IEnumerable<T> entities, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Create_(entities, returning, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create_", entities, returning, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Create_(IEnumerable<T> entities, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Create_(entities, returning, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create_", entities, returning, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Create_(IEnumerable<T> entities, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Create_(entities, returning, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create_", entities, returning, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateAsync_(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateAsync_(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync_", entities, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateAsync_(IEnumerable<T> entities, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateAsync_(entities, returning, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync_", entities, returning, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateAsync_(IEnumerable<T> entities, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateAsync_(entities, returning, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync_", entities, returning, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateAsync_(IEnumerable<T> entities, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateAsync_(entities, returning, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync_", entities, returning, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Create_(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Create_(entities, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create_", entities, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Create_(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Create_(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create_", entities, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Create_(IEnumerable<T> entities, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Create_(entities, returning, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create_", entities, returning, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Create_(IEnumerable<T> entities, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Create_(entities, returning, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create_", entities, returning, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Create_(IEnumerable<T> entities, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Create_(entities, returning, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Create_", entities, returning, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateAsync_(entities, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync_", entities, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateAsync_(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync_", entities, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateAsync_(entities, returning, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync_", entities, returning, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateAsync_(entities, returning, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync_", entities, returning, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateAsync_(entities, returning, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateAsync_", entities, returning, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Update(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Update(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entity, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Update(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Update(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entity, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Update(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Update(entity, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entity, returning, condition, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Update(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Update(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entity, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Update(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Update(entity, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entity, returning, condition, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> UpdateAsync(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.UpdateAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entity, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> UpdateAsync(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.UpdateAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> UpdateAsync(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.UpdateAsync(entity, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entity, returning, condition, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> UpdateAsync(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.UpdateAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> UpdateAsync(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.UpdateAsync(entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Update(T entity, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Update(entity, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entity, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Update(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Update(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entity, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Update(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Update(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entity, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Update(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Update(entity, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entity, returning, condition, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Update(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Update(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entity, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Update(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Update(entity, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entity, returning, condition, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> UpdateAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.UpdateAsync(entity, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entity, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> UpdateAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.UpdateAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entity, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> UpdateAsync(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.UpdateAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> UpdateAsync(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.UpdateAsync(entity, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entity, returning, condition, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> UpdateAsync(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.UpdateAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> UpdateAsync(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.UpdateAsync(entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Update(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Update(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entities, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Update(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Update(entities, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entities, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Update(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Update(entities, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entities, returning, condition, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Update(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Update(entities, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entities, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Update(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Update(entities, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entities, returning, condition, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.UpdateAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entities, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.UpdateAsync(entities, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entities, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.UpdateAsync(entities, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entities, returning, condition, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.UpdateAsync(entities, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entities, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.UpdateAsync(entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Update(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Update(entities, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entities, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Update(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entities, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Update(entities, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entities, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Update(entities, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entities, returning, condition, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Update(entities, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entities, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Update(entities, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Update", entities, returning, condition, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.UpdateAsync(entities, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entities, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.UpdateAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entities, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.UpdateAsync(entities, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entities, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.UpdateAsync(entities, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entities, returning, condition, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.UpdateAsync(entities, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entities, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> UpdateAsync(
        IEnumerable<T> entities,
        string? returning,
        string? condition,
        string? addition,
        object? bindings,
        IDbTransaction? transaction = null,
        int? timeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.UpdateAsync(entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.UpdateAsync", entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int CreateOrUpdate(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.CreateOrUpdate(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entity, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int CreateOrUpdate(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.CreateOrUpdate(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entity, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int CreateOrUpdate(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.CreateOrUpdate(entity, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entity, returning, condition, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int CreateOrUpdate(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.CreateOrUpdate(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entity, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int CreateOrUpdate(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.CreateOrUpdate(entity, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entity, returning, condition, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateOrUpdateAsync(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entity, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateOrUpdateAsync(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateOrUpdateAsync(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entity, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entity, returning, condition, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateOrUpdateAsync(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateOrUpdateAsync(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? CreateOrUpdate(T entity, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.CreateOrUpdate(entity, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entity, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? CreateOrUpdate(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.CreateOrUpdate(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entity, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? CreateOrUpdate(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.CreateOrUpdate(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entity, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? CreateOrUpdate(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.CreateOrUpdate(entity, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entity, returning, condition, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? CreateOrUpdate(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.CreateOrUpdate(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entity, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? CreateOrUpdate(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.CreateOrUpdate(entity, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entity, returning, condition, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> CreateOrUpdateAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entity, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entity, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> CreateOrUpdateAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entity, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> CreateOrUpdateAsync(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> CreateOrUpdateAsync(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entity, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entity, returning, condition, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> CreateOrUpdateAsync(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> CreateOrUpdateAsync(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int CreateOrUpdate(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.CreateOrUpdate(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entities, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int CreateOrUpdate(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.CreateOrUpdate(entities, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entities, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int CreateOrUpdate(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.CreateOrUpdate(entities, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entities, returning, condition, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int CreateOrUpdate(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.CreateOrUpdate(entities, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entities, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int CreateOrUpdate(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.CreateOrUpdate(entities, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entities, returning, condition, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entities, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entities, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entities, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entities, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entities, returning, condition, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entities, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entities, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.CreateOrUpdate(entities, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entities, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.CreateOrUpdate(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entities, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.CreateOrUpdate(entities, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entities, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.CreateOrUpdate(entities, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entities, returning, condition, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.CreateOrUpdate(entities, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entities, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.CreateOrUpdate(entities, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdate", entities, returning, condition, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entities, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entities, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entities, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entities, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entities, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entities, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entities, returning, condition, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entities, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entities, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> CreateOrUpdateAsync(
        IEnumerable<T> entities,
        string? returning,
        string? condition,
        string? addition,
        object? bindings,
        IDbTransaction? transaction = null,
        int? timeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.CreateOrUpdateAsync(entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CreateOrUpdateAsync", entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Delete(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Delete(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entity, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Delete(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Delete(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entity, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Delete(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Delete(entity, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entity, returning, condition, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Delete(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Delete(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entity, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Delete(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Delete(entity, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entity, returning, condition, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> DeleteAsync(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.DeleteAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entity, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> DeleteAsync(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.DeleteAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> DeleteAsync(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.DeleteAsync(entity, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entity, returning, condition, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> DeleteAsync(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.DeleteAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> DeleteAsync(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.DeleteAsync(entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Delete(T entity, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Delete(entity, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entity, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Delete(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Delete(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entity, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Delete(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Delete(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entity, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Delete(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Delete(entity, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entity, returning, condition, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Delete(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Delete(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entity, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Delete(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Delete(entity, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entity, returning, condition, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> DeleteAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.DeleteAsync(entity, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entity, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> DeleteAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.DeleteAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entity, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> DeleteAsync(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.DeleteAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> DeleteAsync(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.DeleteAsync(entity, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entity, returning, condition, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> DeleteAsync(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.DeleteAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> DeleteAsync(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.DeleteAsync(entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Delete(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Delete(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entities, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Delete(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Delete(entities, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entities, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Delete(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Delete(entities, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entities, returning, condition, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Delete(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Delete(entities, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entities, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int Delete(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        int result;
        try
        {
            result = repository.Delete(entities, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entities, returning, condition, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.DeleteAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entities, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.DeleteAsync(entities, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entities, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.DeleteAsync(entities, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entities, returning, condition, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.DeleteAsync(entities, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entities, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        int result;
        try
        {
            result = await repository.DeleteAsync(entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Delete(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Delete(entities, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entities, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Delete(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entities, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Delete(entities, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entities, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Delete(entities, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entities, returning, condition, addition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Delete(entities, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entities, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Delete(entities, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Delete", entities, returning, condition, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.DeleteAsync(entities, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entities, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.DeleteAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entities, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.DeleteAsync(entities, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entities, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.DeleteAsync(entities, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entities, returning, condition, addition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.DeleteAsync(entities, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entities, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> DeleteAsync(
        IEnumerable<T> entities,
        string? returning,
        string? condition,
        string? addition,
        object? bindings,
        IDbTransaction? transaction = null,
        int? timeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.DeleteAsync(entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.DeleteAsync", entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Get(T entity, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Get(entity, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", entity, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Get(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Get(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", entity, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Get(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Get(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", entity, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Get(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Get(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", entity, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Get(T entity, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Get(entity, returning, condition, extension, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", entity, returning, condition, extension, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? Get(T entity, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        T? result;
        try
        {
            result = repository.Get(entity, returning, condition, extension, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", entity, returning, condition, extension, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> GetAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.GetAsync(entity, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", entity, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> GetAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.GetAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", entity, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> GetAsync(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.GetAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> GetAsync(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.GetAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> GetAsync(T entity, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.GetAsync(entity, returning, condition, extension, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", entity, returning, condition, extension, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> GetAsync(T entity, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        T? result;
        try
        {
            result = await repository.GetAsync(entity, returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", entity, returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Get(IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Get(transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Get(string returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Get(returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Get(string returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Get(returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Get(string returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Get(returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Get(string returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Get(returning, condition, extension, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", returning, condition, extension, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Get(string returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Get(returning, condition, extension, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", returning, condition, extension, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> GetAsync(IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.GetAsync(transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> GetAsync(string returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.GetAsync(returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> GetAsync(string returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.GetAsync(returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> GetAsync(string returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.GetAsync(returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> GetAsync(string returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.GetAsync(returning, condition, extension, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", returning, condition, extension, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> GetAsync(string returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.GetAsync(returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Get(long fetch, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Get(fetch, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", fetch, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Get(long fetch, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Get(fetch, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", fetch, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Get(long fetch, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Get(fetch, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", fetch, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Get(long fetch, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Get(fetch, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", fetch, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Get(long fetch, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Get(fetch, returning, condition, extension, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", fetch, returning, condition, extension, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Get(long fetch, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Get(fetch, returning, condition, extension, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", fetch, returning, condition, extension, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> GetAsync(long fetch, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.GetAsync(fetch, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", fetch, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.GetAsync(fetch, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", fetch, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.GetAsync(fetch, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", fetch, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.GetAsync(fetch, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", fetch, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.GetAsync(fetch, returning, condition, extension, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", fetch, returning, condition, extension, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> GetAsync(
        long fetch,
        string? returning,
        string? condition,
        string? extension,
        string? addition,
        object? bindings,
        IDbTransaction? transaction = null,
        int? timeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.GetAsync(fetch, returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", fetch, returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, IDbTransaction? transaction = null, int? timeout = null)
    {
        (IEnumerable<T>?, T1?) result;
        try
        {
            result = repository.Get<T1>(fetch, offset, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", fetch, offset, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        (IEnumerable<T>?, T1?) result;
        try
        {
            result = repository.Get<T1>(fetch, offset, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", fetch, offset, returning, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        (IEnumerable<T>?, T1?) result;
        try
        {
            result = repository.Get<T1>(fetch, offset, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", fetch, offset, returning, condition, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        (IEnumerable<T>?, T1?) result;
        try
        {
            result = repository.Get<T1>(fetch, offset, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", fetch, offset, returning, condition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        (IEnumerable<T>?, T1?) result;
        try
        {
            result = repository.Get<T1>(fetch, offset, returning, condition, extension, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", fetch, offset, returning, condition, extension, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        (IEnumerable<T>?, T1?) result;
        try
        {
            result = repository.Get<T1>(fetch, offset, returning, condition, extension, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Get", fetch, offset, returning, condition, extension, addition, bindings, transaction, timeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        (IEnumerable<T>?, T1?) result;
        try
        {
            result = await repository.GetAsync<T1>(fetch, offset, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", fetch, offset, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        (IEnumerable<T>?, T1?) result;
        try
        {
            result = await repository.GetAsync<T1>(fetch, offset, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", fetch, offset, returning, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        (IEnumerable<T>?, T1?) result;
        try
        {
            result = await repository.GetAsync<T1>(fetch, offset, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", fetch, offset, returning, condition, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        (IEnumerable<T>?, T1?) result;
        try
        {
            result = await repository.GetAsync<T1>(fetch, offset, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", fetch, offset, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(
        long fetch,
        int offset,
        string? returning,
        string? condition,
        string? extension,
        object? bindings,
        IDbTransaction? transaction = null,
        int? timeout = null,
        CancellationToken cancellationToken = default
    )
    {
        (IEnumerable<T>?, T1?) result;
        try
        {
            result = await repository.GetAsync<T1>(fetch, offset, returning, condition, extension, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", fetch, offset, returning, condition, extension, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(
        long fetch,
        int offset,
        string? returning,
        string? condition,
        string? extension,
        string? addition,
        object? bindings,
        IDbTransaction? transaction = null,
        int? timeout = null,
        CancellationToken cancellationToken = default
    )
    {
        (IEnumerable<T>?, T1?) result;
        try
        {
            result = await repository.GetAsync<T1>(fetch, offset, returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetAsync", fetch, offset, returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public int NonQuery(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        int result;
        try
        {
            result = repository.NonQuery(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.NonQuery", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<int> NonQueryAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        int result;
        try
        {
            result = await repository.NonQueryAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.NonQueryAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? Query(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.Query(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.Query", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> QueryAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.QueryAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public T? QueryEntity(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        T? result;
        try
        {
            result = repository.QueryEntity(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryEntity", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<T?> QueryEntityAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        T? result;
        try
        {
            result = await repository.QueryEntityAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryEntityAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<T>? QueryEntities(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        IEnumerable<T>? result;
        try
        {
            result = repository.QueryEntities(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryEntities", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<T>?> QueryEntitiesAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<T>? result;
        try
        {
            result = await repository.QueryEntitiesAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryEntitiesAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public object? QueryScalar(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        object? result;
        try
        {
            result = repository.QueryScalar(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryScalar", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<object?> QueryScalarAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        object? result;
        try
        {
            result = await repository.QueryScalarAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryScalarAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IDataReader QueryReader(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        IDataReader result;
        try
        {
            result = repository.QueryReader(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryReader", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IDataReader> QueryReaderAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IDataReader result;
        try
        {
            result = await repository.QueryReaderAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryReaderAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public DataSet QueryDataSet(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        DataSet result;
        try
        {
            result = repository.QueryDataSet(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataSet", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<DataSet> QueryDataSetAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        DataSet result;
        try
        {
            result = await repository.QueryDataSetAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataSetAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public DataRow QueryDataRow(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        DataRow result;
        try
        {
            result = repository.QueryDataRow(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataRow", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<DataRow> QueryDataRowAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        DataRow result;
        try
        {
            result = await repository.QueryDataRowAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataRowAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<DataRow> QueryDataRows(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        IEnumerable<DataRow> result;
        try
        {
            result = repository.QueryDataRows(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataRows", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<DataRow>> QueryDataRowsAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<DataRow> result;
        try
        {
            result = await repository.QueryDataRowsAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataRowsAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public DataTable QueryDataTable(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        DataTable result;
        try
        {
            result = repository.QueryDataTable(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataTable", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<DataTable> QueryDataTableAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        DataTable result;
        try
        {
            result = await repository.QueryDataTableAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataTableAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<DataTable> QueryDataTables(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        IEnumerable<DataTable> result;
        try
        {
            result = repository.QueryDataTables(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataTables", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<DataTable>> QueryDataTablesAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<DataTable> result;
        try
        {
            result = await repository.QueryDataTablesAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataTablesAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IDataRecord QueryDataRecord(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        IDataRecord result;
        try
        {
            result = repository.QueryDataRecord(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataRecord", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IDataRecord> QueryDataRecordAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IDataRecord result;
        try
        {
            result = await repository.QueryDataRecordAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataRecordAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<IDataRecord> QueryDataRecords(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        IEnumerable<IDataRecord> result;
        try
        {
            result = repository.QueryDataRecords(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataRecords", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<IDataRecord>> QueryDataRecordsAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<IDataRecord> result;
        try
        {
            result = await repository.QueryDataRecordsAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDataRecordsAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public dynamic? QueryDynamic(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        dynamic? result;
        try
        {
            result = repository.QueryDynamic(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDynamic", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<dynamic?> QueryDynamicAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        dynamic? result;
        try
        {
            result = await repository.QueryDynamicAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDynamicAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<dynamic>? QueryDynamics(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        IEnumerable<dynamic>? result;
        try
        {
            result = repository.QueryDynamics(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDynamics", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<dynamic>?> QueryDynamicsAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<dynamic>? result;
        try
        {
            result = await repository.QueryDynamicsAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDynamicsAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IEnumerable<Dictionary<string, IEnumerable<dynamic>?>> QueryDictionaries(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null
    )
    {
        IEnumerable<Dictionary<string, IEnumerable<dynamic>?>> result;
        try
        {
            result = repository.QueryDictionaries(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDictionaries", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw new ServiceException(exception);
        }
        return result;
    }

    public async Task<IEnumerable<Dictionary<string, IEnumerable<dynamic>?>>> QueryDictionariesAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    )
    {
        IEnumerable<Dictionary<string, IEnumerable<dynamic>?>> result;
        try
        {
            result = await repository.QueryDictionariesAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.QueryDictionariesAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw new ServiceException(exception);
        }
        return result;
    }

    public IDbTransaction CreateTransaction()
    {
        IDbTransaction result;
        try
        {
            result = repository.CreateTransaction();
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.GetTransaction"));
            throw new ServiceException(exception);
        }
        return result;
    }

    public void CommitTransaction(IDbTransaction transaction)
    {
        try
        {
            repository.CommitTransaction(transaction);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.CommitTransaction", transaction));
            throw new ServiceException(exception);
        }
    }

    public void RollbackTransaction(IDbTransaction transaction)
    {
        try
        {
            repository.RollbackTransaction(transaction);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, Message("BaseService.RollbackTransaction", transaction));
            throw new ServiceException(exception);
        }
    }
}