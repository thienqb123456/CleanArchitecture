using Domain.Entities;

namespace Application.IRepositories
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Category? GetById(long? id);
    }
}
