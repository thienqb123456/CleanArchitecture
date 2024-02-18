using Domain.Entities.Cms;

namespace Application.Services.Cms.Interfaces
{
    public interface ICategoryService : IBaseService<Category>
    {
        new Category? Create(Category? category, IDbTransaction? transaction = null, int? timeout = null);

        new Category? Update(Category? category, IDbTransaction? transaction = null, int? timeout = null);

        Category? Delete(long? id, IDbTransaction? transaction = null, int? timeout = null);

        Category? GetById(long? id);

    }
}
