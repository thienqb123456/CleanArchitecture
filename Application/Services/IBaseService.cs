namespace Application.Services;

public interface IBaseService<T> where T : class, new()
{
    int Create(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null);

    int Create(T entity, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    int Create(T entity, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    int Create(T entity, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<int> CreateAsync(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateAsync(T entity, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateAsync(T entity, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateAsync(T entity, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    T? Create(T entity, IDbTransaction? transaction = null, int? timeout = null);

    T? Create(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null);

    T? Create(T entity, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    T? Create(T entity, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    T? Create(T entity, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<T?> CreateAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> CreateAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> CreateAsync(T entity, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> CreateAsync(T entity, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> CreateAsync(T entity, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    int Create(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null);

    int Create(IEnumerable<T> entities, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    int Create(IEnumerable<T> entities, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    int Create(IEnumerable<T> entities, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<int> CreateAsync(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateAsync(IEnumerable<T> entities, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateAsync(IEnumerable<T> entities, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateAsync(IEnumerable<T> entities, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    IEnumerable<T>? Create(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Create(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Create(IEnumerable<T> entities, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Create(IEnumerable<T> entities, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Create(IEnumerable<T> entities, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateAsync(IEnumerable<T> entities, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    int Create_(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null);

    int Create_(IEnumerable<T> entities, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    int Create_(IEnumerable<T> entities, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    int Create_(IEnumerable<T> entities, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<int> CreateAsync_(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateAsync_(IEnumerable<T> entities, bool returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateAsync_(IEnumerable<T> entities, bool returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateAsync_(IEnumerable<T> entities, bool returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    IEnumerable<T>? Create_(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Create_(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Create_(IEnumerable<T> entities, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Create_(IEnumerable<T> entities, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Create_(IEnumerable<T> entities, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, string? returning, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, string? returning, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateAsync_(IEnumerable<T> entities, string? returning, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    int Update(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null);

    int Update(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    int Update(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    int Update(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    int Update(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<int> UpdateAsync(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> UpdateAsync(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> UpdateAsync(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> UpdateAsync(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> UpdateAsync(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    T? Update(T entity, IDbTransaction? transaction = null, int? timeout = null);

    T? Update(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null);

    T? Update(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    T? Update(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    T? Update(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    T? Update(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<T?> UpdateAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> UpdateAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> UpdateAsync(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> UpdateAsync(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> UpdateAsync(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> UpdateAsync(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    int Update(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null);

    int Update(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    int Update(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    int Update(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    int Update(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> UpdateAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    IEnumerable<T>? Update(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Update(IEnumerable<T> entities, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> UpdateAsync(IEnumerable<T> entities, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    int CreateOrUpdate(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null);

    int CreateOrUpdate(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    int CreateOrUpdate(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    int CreateOrUpdate(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    int CreateOrUpdate(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<int> CreateOrUpdateAsync(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateOrUpdateAsync(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateOrUpdateAsync(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateOrUpdateAsync(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateOrUpdateAsync(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    T? CreateOrUpdate(T entity, IDbTransaction? transaction = null, int? timeout = null);

    T? CreateOrUpdate(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null);

    T? CreateOrUpdate(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    T? CreateOrUpdate(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    T? CreateOrUpdate(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    T? CreateOrUpdate(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<T?> CreateOrUpdateAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> CreateOrUpdateAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> CreateOrUpdateAsync(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> CreateOrUpdateAsync(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> CreateOrUpdateAsync(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> CreateOrUpdateAsync(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    int CreateOrUpdate(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null);

    int CreateOrUpdate(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    int CreateOrUpdate(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    int CreateOrUpdate(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    int CreateOrUpdate(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> CreateOrUpdateAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? CreateOrUpdate(IEnumerable<T> entities, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> CreateOrUpdateAsync(IEnumerable<T> entities, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    int Delete(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null);

    int Delete(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    int Delete(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    int Delete(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    int Delete(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<int> DeleteAsync(T entity, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> DeleteAsync(T entity, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> DeleteAsync(T entity, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> DeleteAsync(T entity, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> DeleteAsync(T entity, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    T? Delete(T entity, IDbTransaction? transaction = null, int? timeout = null);

    T? Delete(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null);

    T? Delete(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    T? Delete(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    T? Delete(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    T? Delete(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<T?> DeleteAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> DeleteAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> DeleteAsync(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> DeleteAsync(T entity, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> DeleteAsync(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> DeleteAsync(T entity, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    int Delete(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null);

    int Delete(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    int Delete(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    int Delete(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    int Delete(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<int> DeleteAsync(IEnumerable<T> entities, bool returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    IEnumerable<T>? Delete(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Delete(IEnumerable<T> entities, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, string? condition, string? addition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> DeleteAsync(IEnumerable<T> entities, string? returning, string? condition, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    T? Get(T entity, IDbTransaction? transaction = null, int? timeout = null);

    T? Get(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null);

    T? Get(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    T? Get(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    T? Get(T entity, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    T? Get(T entity, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<T?> GetAsync(T entity, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> GetAsync(T entity, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> GetAsync(T entity, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> GetAsync(T entity, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> GetAsync(T entity, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<T?> GetAsync(T entity, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    IEnumerable<T>? Get(IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Get(string returning, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Get(string returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Get(string returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Get(string returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Get(string returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<IEnumerable<T>?> GetAsync(IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> GetAsync(string returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> GetAsync(string returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> GetAsync(string returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> GetAsync(string returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> GetAsync(string returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    IEnumerable<T>? Get(long fetch, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Get(long fetch, string? returning, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Get(long fetch, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Get(long fetch, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Get(long fetch, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    IEnumerable<T>? Get(long fetch, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<IEnumerable<T>?> GetAsync(long fetch, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<IEnumerable<T>?> GetAsync(long fetch, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, IDbTransaction? transaction = null, int? timeout = null);

    (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, IDbTransaction? transaction = null, int? timeout = null);

    (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null);

    (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    (IEnumerable<T>?, T1?) Get<T1>(long fetch, int offset, string? returning, string? condition, string? extension, string? addition, object? bindings, IDbTransaction? transaction = null, int? timeout = null);

    Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, string? returning, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, string? returning, string? condition, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, string? returning, string? condition, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(long fetch, int offset, string? returning, string? condition, string? extension, object? bindings, IDbTransaction? transaction = null, int? timeout = null, CancellationToken cancellationToken = default);

    Task<(IEnumerable<T>?, T1?)> GetAsync<T1>(
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
    );

    int NonQuery(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<int> NonQueryAsync(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null, CancellationToken cancellationToken = default);

    IEnumerable<T>? Query(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<IEnumerable<T>?> QueryAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    T? QueryEntity(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<T?> QueryEntityAsync(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null, CancellationToken cancellationToken = default);

    IEnumerable<T>? QueryEntities(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<IEnumerable<T>?> QueryEntitiesAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    object? QueryScalar(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<object?> QueryScalarAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    IDataReader QueryReader(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<IDataReader> QueryReaderAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    DataSet QueryDataSet(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<DataSet> QueryDataSetAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    DataRow QueryDataRow(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<DataRow> QueryDataRowAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    IEnumerable<DataRow> QueryDataRows(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<IEnumerable<DataRow>> QueryDataRowsAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    DataTable QueryDataTable(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<DataTable> QueryDataTableAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    IEnumerable<DataTable> QueryDataTables(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<IEnumerable<DataTable>> QueryDataTablesAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    IDataRecord QueryDataRecord(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<IDataRecord> QueryDataRecordAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    IEnumerable<IDataRecord> QueryDataRecords(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<IEnumerable<IDataRecord>> QueryDataRecordsAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    dynamic? QueryDynamic(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<dynamic?> QueryDynamicAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    IEnumerable<dynamic>? QueryDynamics(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<IEnumerable<dynamic>?> QueryDynamicsAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    IEnumerable<Dictionary<string, IEnumerable<dynamic>?>> QueryDictionaries(string commandText, object? commandParameters = null, CommandType? commandType = CommandType.Text, IDbTransaction? commandTransaction = null, int? commandTimeout = null);

    Task<IEnumerable<Dictionary<string, IEnumerable<dynamic>?>>> QueryDictionariesAsync(
        string commandText,
        object? commandParameters = null,
        CommandType? commandType = CommandType.Text,
        IDbTransaction? commandTransaction = null,
        int? commandTimeout = null,
        CancellationToken cancellationToken = default
    );

    IDbTransaction CreateTransaction();

    void CommitTransaction(IDbTransaction transaction);

    void RollbackTransaction(IDbTransaction transaction);
}