using Domain.Entities.Cms;

namespace Application.IRepositories.Cms
{
    public interface IClothingRepository : IBaseRepository<Clothing>
    {
        Clothing? GetById(long? id);
    }
}
