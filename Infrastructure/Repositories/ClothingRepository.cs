using Application.IRepositories.Cms;
using Domain.Entities.Cms;

namespace Infrastructure.Repositories
{
    public class ClothingRepository : BaseRepository<Clothing>, IClothingRepository
    {
        private readonly ILogger<ClothingRepository> _logger;
        private readonly DbFactory _factory;

        private readonly string _clothingTarget = EntityUtility.TargetName<Clothing>();

        public ClothingRepository(ILogger<ClothingRepository> logger, DbFactory factory) : base(logger, factory)
        {
            _logger = logger;
            _factory = factory;
        }

        public ClothingRepository(ILogger<ClothingRepository> logger, NamedServiceResolver<DbFactory> services) : base(logger, services)
        {
            _logger = logger;
            _factory = services["PostgreSql"];
        }

        public Clothing? GetById(long? id)
        {
            try
            {
                var statement = $"SELECT {_clothingTarget}.* FROM {_clothingTarget} WHERE {_clothingTarget}.\"Id\"=@Id ";
                return _factory.ExecuteEntity<Clothing>(statement, new { Id = id });
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, Message("ClothingRepository.GetById", id));
                throw;
            }
        }
    }
}
