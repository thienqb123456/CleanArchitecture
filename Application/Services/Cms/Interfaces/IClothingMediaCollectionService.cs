using Domain.Entities.Cms;

namespace Application.Services.Cms.Interfaces
{
    public interface IClothingMediaCollectionService : IBaseService<ClothingMediaCollection>
    {
        new ClothingMediaCollection? Create(ClothingMediaCollection? clothingMediaCollection, IDbTransaction? transaction = null, int? timeout = null);

        new ClothingMediaCollection? Update(ClothingMediaCollection? clothingMediaCollection, IDbTransaction? transaction = null, int? timeout = null);

        ClothingMediaCollection? Delete(long? id, IDbTransaction? transaction = null, int? timeout = null);

        ClothingMediaCollection? GetById(long? id);

    }
}
