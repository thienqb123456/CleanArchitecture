using Application.IRepositories.Cms;
using Application.Services.Cms.Interfaces;
using Domain.Entities.Cms;

namespace Application.Services.Cms
{
    public class ClothingMediaCollectionService(ILogger<ClothingMediaCollectionService> logger, IClothingMediaCollectionRepository clothingMediaCollectionRepository) : BaseService<ClothingMediaCollection>(logger, clothingMediaCollectionRepository), IClothingMediaCollectionService
    {
        public new ClothingMediaCollection? Create(ClothingMediaCollection? clothingMediaCollection, IDbTransaction? transaction = null, int? timeout = null)
        {
            ClothingMediaCollection? result;
            try
            {
                if (clothingMediaCollection == null) return null;
                clothingMediaCollection.CreatedBy = 0;
                clothingMediaCollection.CreatedOn = DateTime.UtcNow;
                result = clothingMediaCollectionRepository.Create(clothingMediaCollection, transaction, timeout);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("ClothingMediaCollectionService.Create", clothingMediaCollection, transaction, timeout));
                throw;
            }
            return result;
        }

        public new ClothingMediaCollection? Update(ClothingMediaCollection? clothingMediaCollection, IDbTransaction? transaction = null, int? timeout = null)
        {
            ClothingMediaCollection? result;
            try
            {
                if (clothingMediaCollection == null) return null;
                clothingMediaCollection.UpdatedBy = 0;
                clothingMediaCollection.UpdatedOn = DateTime.UtcNow;
                result = clothingMediaCollectionRepository.Create(clothingMediaCollection, transaction, timeout);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("ClothingMediaCollectionService.Update", clothingMediaCollection, transaction, timeout));
                throw;
            }
            return result;
        }

        public ClothingMediaCollection? Delete(long? id, IDbTransaction? transaction = null, int? timeout = null)
        {
            ClothingMediaCollection? result;
            try
            {
                if (id == null) return null;
                result = clothingMediaCollectionRepository.Delete(new ClothingMediaCollection { Id = id }, transaction, timeout);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("ClothingMediaCollectionService.Delete", id, transaction, timeout));
                throw;
            }
            return result;
        }

        public ClothingMediaCollection? GetById(long? id)
        {
            ClothingMediaCollection? result;
            try
            {
                if (id == null) return null;
                result = clothingMediaCollectionRepository.GetById(id);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("ClothingMediaCollectionService.GetById", id));
                throw;
            }
            return result;
        }
    }
}
