using Domain.Entities.Cms;

namespace Application.IRepositories.Cms
{
    public interface IClothingMediaCollectionRepository : IBaseRepository<ClothingMediaCollection>
    {
        ClothingMediaCollection? GetById(long? id);
    }
}
