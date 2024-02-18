using Application.IRepositories.Cms;
using Domain.Entities.Cms;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly ILogger<CategoryRepository> _logger;
        private readonly DbFactory _factory;

        private readonly string _categoryTarget = EntityUtility.TargetName<Category>();

        public CategoryRepository(ILogger<CategoryRepository> logger, DbFactory factory) : base(logger, factory)
        {
            _logger = logger;
            _factory = factory;
        }

        public CategoryRepository(ILogger<CategoryRepository> logger, NamedServiceResolver<DbFactory> services) : base(logger, services)
        {
            _logger = logger;
            _factory = services["PostgreSql"];
        }

        public Category? GetById(long? id)
        {
            try
            {
                var statement = $"SELECT {_categoryTarget}.* FROM {_categoryTarget} WHERE {_categoryTarget}.\"Id\"=@Id ";
                return _factory.ExecuteEntity<Category>(statement, new { Id = id });
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, Message("CategoryRepository.GetById", id));
                throw;
            }
        }
    }
}
