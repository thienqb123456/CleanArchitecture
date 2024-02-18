using Domain.Entities.Cms;

namespace Application.Services.Cms.Interfaces
{
    public interface IClothingService : IBaseService<Clothing>
    {
        new Clothing? Create(Clothing? clothing, IDbTransaction? transaction = null, int? timeout = null);

        new Clothing? Update(Clothing? clothing, IDbTransaction? transaction = null, int? timeout = null);

        Clothing? Delete(long? id, IDbTransaction? transaction = null, int? timeout = null);

        Clothing? GetById(long? id);

    }
}
