using Application.IRepositories;

namespace Infrastructure.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
{
    private readonly ILogger<BaseRepository<T>> _logger;
    private readonly DbFactory _factory;

    public BaseRepository(ILogger<BaseRepository<T>> logger, DbFactory factory)
    {
        _logger = logger;
        _factory = factory;
    }

    public BaseRepository(ILogger<BaseRepository<T>> logger, NamedServiceResolver<DbFactory> services)
    {
        _logger = logger;
        _factory = services["PostgreSql"];
    }

    public int Create(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entity, returning, transaction, timeout));
            throw;
        }
    }

    public int Create(T entity, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entity, returning, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entity, returning, addition, transaction, timeout));
            throw;
        }
    }

    public int Create(T entity, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entity, returning, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entity, returning, bindings, transaction, timeout));
            throw;
        }
    }

    public int Create(T entity, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entity, returning, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entity, returning, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<int> CreateAsync(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entity, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateAsync(T entity, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entity, returning, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entity, returning, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateAsync(T entity, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entity, returning, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entity, returning, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateAsync(T entity, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entity, returning, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entity, returning, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public T? Create(T entity, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entity, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entity, transaction, timeout));
            throw;
        }
    }

    public T? Create(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entity, returning, transaction, timeout));
            throw;
        }
    }

    public T? Create(T entity, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entity, returning, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entity, returning, addition, transaction, timeout));
            throw;
        }
    }

    public T? Create(T entity, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entity, returning, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entity, returning, bindings, transaction, timeout));
            throw;
        }
    }

    public T? Create(T entity, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entity, returning, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entity, returning, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<T?> CreateAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entity, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entity, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> CreateAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entity, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> CreateAsync(T entity, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entity, returning, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entity, returning, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> CreateAsync(T entity, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entity, returning, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entity, returning, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> CreateAsync(T entity, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entity, returning, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entity, returning, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public int Create(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entities, returning, transaction, timeout));
            throw;
        }
    }

    public int Create(IEnumerable<T> entities, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entities, returning, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entities, returning, addition, transaction, timeout));
            throw;
        }
    }

    public int Create(IEnumerable<T> entities, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entities, returning, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entities, returning, bindings, transaction, timeout));
            throw;
        }
    }

    public int Create(IEnumerable<T> entities, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entities, returning, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entities, returning, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<int> CreateAsync(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entities, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateAsync(IEnumerable<T> entities, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entities, returning, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entities, returning, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateAsync(IEnumerable<T> entities, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entities, returning, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entities, returning, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateAsync(IEnumerable<T> entities, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entities, returning, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entities, returning, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<T>? Create(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entities, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entities, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Create(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entities, returning, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Create(IEnumerable<T> entities, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entities, returning, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entities, returning, addition, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Create(IEnumerable<T> entities, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entities, returning, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entities, returning, bindings, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Create(IEnumerable<T> entities, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert(entities, returning, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create", entities, returning, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entities, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entities, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entities, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entities, returning, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entities, returning, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entities, returning, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entities, returning, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync(entities, returning, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync", entities, returning, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public int Create_(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert_(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create_", entities, returning, transaction, timeout));
            throw;
        }
    }

    public int Create_(IEnumerable<T> entities, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert_(entities, returning, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create_", entities, returning, addition, transaction, timeout));
            throw;
        }
    }

    public int Create_(IEnumerable<T> entities, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert_(entities, returning, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create_", entities, returning, bindings, transaction, timeout));
            throw;
        }
    }

    public int Create_(IEnumerable<T> entities, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert_(entities, returning, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create_", entities, returning, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<int> CreateAsync_(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync_(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync_", entities, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateAsync_(IEnumerable<T> entities, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync_(entities, returning, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync_", entities, returning, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateAsync_(IEnumerable<T> entities, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync_(entities, returning, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync_", entities, returning, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateAsync_(IEnumerable<T> entities, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync_(entities, returning, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync_", entities, returning, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<T>? Create_(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert_(entities, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create_", entities, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Create_(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert_(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create_", entities, returning, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Create_(IEnumerable<T> entities, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert_(entities, returning, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create_", entities, returning, addition, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Create_(IEnumerable<T> entities, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert_(entities, returning, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create_", entities, returning, bindings, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Create_(IEnumerable<T> entities, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Insert_(entities, returning, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Create_", entities, returning, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync_(entities, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync_", entities, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync_(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync_", entities, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync_(entities, returning, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync_", entities, returning, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync_(entities, returning, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync_", entities, returning, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.InsertAsync_(entities, returning, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateAsync_", entities, returning, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public int Update(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entity, returning, transaction, timeout));
            throw;
        }
    }

    public int Update(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entity, returning, condition, transaction, timeout));
            throw;
        }
    }

    public int Update(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entity, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entity, returning, condition, addition, transaction, timeout));
            throw;
        }
    }

    public int Update(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entity, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public int Update(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entity, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entity, returning, condition, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<int> UpdateAsync(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entity, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> UpdateAsync(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> UpdateAsync(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entity, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entity, returning, condition, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> UpdateAsync(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> UpdateAsync(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public T? Update(T entity, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entity, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entity, transaction, timeout));
            throw;
        }
    }

    public T? Update(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entity, returning, transaction, timeout));
            throw;
        }
    }

    public T? Update(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entity, returning, condition, transaction, timeout));
            throw;
        }
    }

    public T? Update(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entity, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entity, returning, condition, addition, transaction, timeout));
            throw;
        }
    }

    public T? Update(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entity, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public T? Update(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entity, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entity, returning, condition, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<T?> UpdateAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entity, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entity, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> UpdateAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entity, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> UpdateAsync(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> UpdateAsync(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entity, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entity, returning, condition, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> UpdateAsync(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> UpdateAsync(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public int Update(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entities, returning, transaction, timeout));
            throw;
        }
    }

    public int Update(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entities, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entities, returning, condition, transaction, timeout));
            throw;
        }
    }

    public int Update(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entities, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entities, returning, condition, addition, transaction, timeout));
            throw;
        }
    }

    public int Update(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entities, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entities, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public int Update(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entities, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entities, returning, condition, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entities, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entities, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entities, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entities, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entities, returning, condition, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entities, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entities, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<T>? Update(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entities, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entities, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entities, returning, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entities, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entities, returning, condition, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entities, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entities, returning, condition, addition, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entities, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entities, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Update(entities, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Update", entities, returning, condition, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entities, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entities, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entities, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entities, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entities, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entities, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entities, returning, condition, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpdateAsync(entities, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entities, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
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
        try
        {
            return await _factory.UpdateAsync(entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.UpdateAsync", entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public int CreateOrUpdate(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entity, returning, transaction, timeout));
            throw;
        }
    }

    public int CreateOrUpdate(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entity, returning, condition, transaction, timeout));
            throw;
        }
    }

    public int CreateOrUpdate(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entity, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entity, returning, condition, addition, transaction, timeout));
            throw;
        }
    }

    public int CreateOrUpdate(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entity, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public int CreateOrUpdate(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entity, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entity, returning, condition, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<int> CreateOrUpdateAsync(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entity, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateOrUpdateAsync(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateOrUpdateAsync(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entity, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entity, returning, condition, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateOrUpdateAsync(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateOrUpdateAsync(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public T? CreateOrUpdate(T entity, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entity, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entity, transaction, timeout));
            throw;
        }
    }

    public T? CreateOrUpdate(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entity, returning, transaction, timeout));
            throw;
        }
    }

    public T? CreateOrUpdate(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entity, returning, condition, transaction, timeout));
            throw;
        }
    }

    public T? CreateOrUpdate(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entity, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entity, returning, condition, addition, transaction, timeout));
            throw;
        }
    }

    public T? CreateOrUpdate(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entity, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public T? CreateOrUpdate(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entity, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entity, returning, condition, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<T?> CreateOrUpdateAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entity, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entity, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> CreateOrUpdateAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entity, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> CreateOrUpdateAsync(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> CreateOrUpdateAsync(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entity, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entity, returning, condition, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> CreateOrUpdateAsync(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> CreateOrUpdateAsync(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public int CreateOrUpdate(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entities, returning, transaction, timeout));
            throw;
        }
    }

    public int CreateOrUpdate(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entities, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entities, returning, condition, transaction, timeout));
            throw;
        }
    }

    public int CreateOrUpdate(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entities, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entities, returning, condition, addition, transaction, timeout));
            throw;
        }
    }

    public int CreateOrUpdate(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entities, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entities, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public int CreateOrUpdate(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entities, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entities, returning, condition, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entities, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entities, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entities, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entities, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entities, returning, condition, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entities, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entities, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entities, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entities, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entities, returning, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entities, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entities, returning, condition, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entities, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entities, returning, condition, addition, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entities, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entities, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Upsert(entities, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdate", entities, returning, condition, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entities, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entities, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entities, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entities, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entities, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entities, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entities, returning, condition, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.UpsertAsync(entities, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entities, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
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
        try
        {
            return await _factory.UpsertAsync(entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateOrUpdateAsync", entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public int Delete(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entity, returning, transaction, timeout));
            throw;
        }
    }

    public int Delete(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entity, returning, condition, transaction, timeout));
            throw;
        }
    }

    public int Delete(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entity, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entity, returning, condition, addition, transaction, timeout));
            throw;
        }
    }

    public int Delete(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entity, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public int Delete(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entity, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entity, returning, condition, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<int> DeleteAsync(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entity, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> DeleteAsync(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> DeleteAsync(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entity, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entity, returning, condition, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> DeleteAsync(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> DeleteAsync(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public T? Delete(T entity, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entity, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entity, transaction, timeout));
            throw;
        }
    }

    public T? Delete(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entity, returning, transaction, timeout));
            throw;
        }
    }

    public T? Delete(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entity, returning, condition, transaction, timeout));
            throw;
        }
    }

    public T? Delete(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entity, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entity, returning, condition, addition, transaction, timeout));
            throw;
        }
    }

    public T? Delete(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entity, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public T? Delete(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entity, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entity, returning, condition, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<T?> DeleteAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entity, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entity, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> DeleteAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entity, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> DeleteAsync(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> DeleteAsync(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entity, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entity, returning, condition, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> DeleteAsync(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> DeleteAsync(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entity, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public int Delete(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entities, returning, transaction, timeout));
            throw;
        }
    }

    public int Delete(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entities, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entities, returning, condition, transaction, timeout));
            throw;
        }
    }

    public int Delete(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entities, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entities, returning, condition, addition, transaction, timeout));
            throw;
        }
    }

    public int Delete(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entities, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entities, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public int Delete(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entities, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entities, returning, condition, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entities, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entities, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entities, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entities, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entities, returning, condition, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entities, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entities, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<T>? Delete(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entities, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entities, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entities, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entities, returning, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entities, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entities, returning, condition, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entities, returning, condition, addition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entities, returning, condition, addition, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entities, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entities, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Delete(entities, returning, condition, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Delete", entities, returning, condition, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entities, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entities, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entities, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entities, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entities, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entities, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entities, returning, condition, addition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entities, returning, condition, addition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.DeleteAsync(entities, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entities, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
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
        try
        {
            return await _factory.DeleteAsync(entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.DeleteAsync", entities, returning, condition, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public T? Get(T entity, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select(entity, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", entity, transaction, timeout));
            throw;
        }
    }

    public T? Get(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select(entity, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", entity, returning, transaction, timeout));
            throw;
        }
    }

    public T? Get(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select(entity, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", entity, returning, condition, transaction, timeout));
            throw;
        }
    }

    public T? Get(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select(entity, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", entity, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public T? Get(T entity, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select(entity, returning, condition, extension, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", entity, returning, condition, extension, bindings, transaction, timeout));
            throw;
        }
    }

    public T? Get(T entity, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select(entity, returning, condition, extension, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", entity, returning, condition, extension, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<T?> GetAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync(entity, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", entity, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> GetAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync(entity, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", entity, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> GetAsync(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync(entity, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", entity, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> GetAsync(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync(entity, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", entity, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> GetAsync(T entity, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync(entity, returning, condition, extension, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", entity, returning, condition, extension, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<T?> GetAsync(T entity, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync(entity, returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", entity, returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<T>? Get(IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T>(transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Get(string returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T>(returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", returning, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Get(string returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T>(returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", returning, condition, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Get(string returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T>(returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Get(string returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T>(returning, condition, extension, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", returning, condition, extension, bindings, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Get(string returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T>(returning, condition, extension, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", returning, condition, extension, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> GetAsync(IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T>(transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> GetAsync(string returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T>(returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> GetAsync(string returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T>(returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> GetAsync(string returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T>(returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> GetAsync(string returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T>(returning, condition, extension, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", returning, condition, extension, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> GetAsync(string returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T>(returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<T>? Get(long fetch, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T>(fetch, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", fetch, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Get(long fetch, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T>(fetch, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", fetch, returning, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Get(long fetch, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T>(fetch, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", fetch, returning, condition, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Get(long fetch, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T>(fetch, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", fetch, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Get(long fetch, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T>(fetch, returning, condition, extension, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", fetch, returning, condition, extension, bindings, transaction, timeout));
            throw;
        }
    }

    public IEnumerable<T>? Get(long fetch, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T>(fetch, returning, condition, extension, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", fetch, returning, condition, extension, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> GetAsync(long fetch, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T>(fetch, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", fetch, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T>(fetch, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", fetch, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T>(fetch, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", fetch, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T>(fetch, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", fetch, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T>(fetch, returning, condition, extension, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", fetch, returning, condition, extension, bindings, transaction, timeout, cancellationToken));
            throw;
        }
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
        try
        {
            return await _factory.SelectAsync<T>(fetch, returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", fetch, returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T, T1>(fetch, offset, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", fetch, offset, transaction, timeout));
            throw;
        }
    }

    public (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T, T1>(fetch, offset, returning, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", fetch, offset, returning, transaction, timeout));
            throw;
        }
    }

    public (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T, T1>(fetch, offset, returning, condition, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", fetch, offset, returning, condition, transaction, timeout));
            throw;
        }
    }

    public (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T, T1>(fetch, offset, returning, condition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", fetch, offset, returning, condition, bindings, transaction, timeout));
            throw;
        }
    }

    public (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T, T1>(fetch, offset, returning, condition, extension, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", fetch, offset, returning, condition, extension, bindings, transaction, timeout));
            throw;
        }
    }

    public (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null)
    {
        try
        {
            return _factory.Select<T, T1>(fetch, offset, returning, condition, extension, addition, bindings, transaction, timeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Get", fetch, offset, returning, condition, extension, addition, bindings, transaction, timeout));
            throw;
        }
    }

    public async Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T, T1>(fetch, offset, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", fetch, offset, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T, T1>(fetch, offset, returning, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", fetch, offset, returning, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T, T1>(fetch, offset, returning, condition, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", fetch, offset, returning, condition, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public async Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _factory.SelectAsync<T, T1>(fetch, offset, returning, condition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", fetch, offset, returning, condition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
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
        try
        {
            return await _factory.SelectAsync<T, T1>(fetch, offset, returning, condition, extension, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", fetch, offset, returning, condition, extension, bindings, transaction, timeout, cancellationToken));
            throw;
        }
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
        try
        {
            return await _factory.SelectAsync<T, T1>(fetch, offset, returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.GetAsync", fetch, offset, returning, condition, extension, addition, bindings, transaction, timeout, cancellationToken));
            throw;
        }
    }

    public int NonQuery(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteNonQuery(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.NonQuery", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteNonQueryAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.NonQueryAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<T>? Query(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.Execute<T>(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.Query", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteAsync<T>(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public T? QueryEntity(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteEntity<T>(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryEntity", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteEntityAsync<T>(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryEntityAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<T>? QueryEntities(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteEntities<T>(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryEntities", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteEntitiesAsync<T>(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryEntitiesAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public object? QueryScalar(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteScalar(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryScalar", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteScalarAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryScalarAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public IDataReader QueryReader(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteReader(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryReader", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteReaderAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryReaderAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public DataSet QueryDataSet(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteDataSet(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataSet", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteDataSetAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataSetAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public DataRow QueryDataRow(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteDataRow(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataRow", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteDataRowAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataRowAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<DataRow> QueryDataRows(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteDataRows(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataRows", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteDataRowsAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataRowsAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public DataTable QueryDataTable(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteDataTable(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataTable", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteDataTableAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataTableAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<DataTable> QueryDataTables(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteDataTables(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataTables", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteDataTablesAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataTablesAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public IDataRecord QueryDataRecord(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteDataRecord(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataRecord", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteDataRecordAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataRecordAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<IDataRecord> QueryDataRecords(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteDataRecords(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataRecords", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteDataRecordsAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDataRecordsAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public dynamic? QueryDynamic(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteDynamic(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDynamic", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteDynamicAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDynamicAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<dynamic>? QueryDynamics(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null)
    {
        try
        {
            return _factory.ExecuteDynamics(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDynamics", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteDynamicsAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDynamicsAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public IEnumerable<Dictionary<string, IEnumerable<dynamic>?>> QueryDictionaries(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null
    )
    {
        try
        {
            return _factory.ExecuteDictionaries(commandText, commandParameters, commandType, commandTransaction, commandTimeout);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDictionaries", commandText, commandParameters, commandType, commandTransaction, commandTimeout));
            throw;
        }
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
        try
        {
            return await _factory.ExecuteDictionariesAsync(commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken);
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.QueryDictionariesAsync", commandText, commandParameters, commandType, commandTransaction, commandTimeout, cancellationToken));
            throw;
        }
    }

    public IDbTransaction CreateTransaction()
    {
        try
        {
            return _factory.CreateTransaction();
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CreateTransaction"));
            throw;
        }
    }

    public void CommitTransaction(IDbTransaction transaction)
    {
        try
        {
            transaction.Commit();
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.CommitTransaction", transaction));
            throw;
        }
    }

    public void RollbackTransaction(IDbTransaction transaction)
    {
        try
        {
            transaction.Rollback();
        }
        catch (Exception exception)
        {
            _logger.LogError(exception, Message("BaseRepository.RollbackTransaction", transaction));
            throw;
        }
    }
}