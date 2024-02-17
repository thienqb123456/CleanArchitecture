using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface ICategoryService : IBaseService<Category>
    {
        Category? GetById(long? id);
    }
}
