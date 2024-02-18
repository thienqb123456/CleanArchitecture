using Application.IRepositories.Cms;
using Domain.Entities.Cms;

namespace Infrastructure.Repositories
{
    public class ClothingMediaCollectionRepository : BaseRepository<ClothingMediaCollection>, IClothingMediaCollectionRepository
    {
        private readonly ILogger<ClothingMediaCollectionRepository> _logger;
        private readonly DbFactory _factory;

        private readonly string _clothingMediaCollectionTarget = EntityUtility.TargetName<ClothingMediaCollection>();

        public ClothingMediaCollectionRepository(ILogger<ClothingMediaCollectionRepository> logger, DbFactory factory) : base(logger, factory)
        {
            _logger = logger;
            _factory = factory;
        }

        public ClothingMediaCollectionRepository(ILogger<ClothingMediaCollectionRepository> logger, NamedServiceResolver<DbFactory> services) : base(logger, services)
        {
            _logger = logger;
            _factory = services["PostgreSql"];
        }

        public ClothingMediaCollection? GetById(long? id)
        {
            try
            {
                var statement = $"SELECT {_clothingMediaCollectionTarget}.* FROM {_clothingMediaCollectionTarget} WHERE {_clothingMediaCollectionTarget}.\"Id\"=@Id ";
                return _factory.ExecuteEntity<ClothingMediaCollection>(statement, new { Id = id });
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, Message("ClothingMediaCollectionRepository.GetById", id));
                throw;
            }
        }
    }
}
