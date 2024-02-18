using Domain.Entities.Cms;

namespace Application.IRepositories.Cms
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Category? GetById(long? id);
    }
}
