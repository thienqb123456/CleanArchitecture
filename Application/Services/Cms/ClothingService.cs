using Application.IRepositories.Cms;
using Application.Services.Cms.Interfaces;
using Domain.Entities.Cms;

namespace Application.Services.Cms
{
    public class ClothingService(ILogger<ClothingService> logger, IClothingRepository clothingRepository) : BaseService<Clothing>(logger, clothingRepository), IClothingService
    {
        public new Clothing? Create(Clothing? clothing, IDbTransaction? transaction = null, int? timeout = null)
        {
            Clothing? result;
            try
            {
                if (clothing == null) return null;
                clothing.CreatedBy = 0;
                clothing.CreatedOn = DateTime.UtcNow;
                result = clothingRepository.Create(clothing, transaction, timeout);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("ClothingService.Create", clothing, transaction, timeout));
                throw;
            }
            return result;
        }

        public new Clothing? Update(Clothing? clothing, IDbTransaction? transaction = null, int? timeout = null)
        {
            Clothing? result;
            try
            {
                if (clothing == null) return null;
                clothing.UpdatedBy = 0;
                clothing.UpdatedOn = DateTime.UtcNow;
                result = clothingRepository.Create(clothing, transaction, timeout);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("ClothingService.Update", clothing, transaction, timeout));
                throw;
            }
            return result;
        }

        public Clothing? Delete(long? id, IDbTransaction? transaction = null, int? timeout = null)
        {
            Clothing? result;
            try
            {
                if (id == null) return null;
                result = clothingRepository.Delete(new Clothing { Id = id }, transaction, timeout);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("ClothingService.Delete", id, transaction, timeout));
                throw;
            }
            return result;
        }

        public Clothing? GetById(long? id)
        {
            Clothing? result;
            try
            {
                if (id == null) return null;
                result = clothingRepository.GetById(id);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("ClothingService.GetById", id));
                throw;
            }
            return result;
        }
    }
}
