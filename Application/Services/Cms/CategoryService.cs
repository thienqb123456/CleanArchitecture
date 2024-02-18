using Application.IRepositories.Cms;
using Application.Services.Cms.Interfaces;
using Domain.Entities.Cms;

namespace Application.Services.Cms
{
    public class CategoryService(ILogger<CategoryService> logger, ICategoryRepository categoryRepository) : BaseService<Category>(logger, categoryRepository), ICategoryService
    {
        public new Category? Create(Category? category, IDbTransaction? transaction = null, int? timeout = null)
        {
            Category? result;
            try
            {
                if (category == null) return null;
                category.CreatedBy = 0;
                category.CreatedOn = DateTime.UtcNow;
                result = categoryRepository.Create(category, transaction, timeout);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("CategoryService.Create", category, transaction, timeout));
                throw;
            }
            return result;
        }

        public new Category? Update(Category? category, IDbTransaction? transaction = null, int? timeout = null)
        {
            Category? result;
            try
            {
                if (category == null) return null;
                category.UpdatedBy = 0;
                category.UpdatedOn = DateTime.UtcNow;
                result = categoryRepository.Create(category, transaction, timeout);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("CategoryService.Update", category, transaction, timeout));
                throw;
            }
            return result;
        }

        public Category? Delete(long? id, IDbTransaction? transaction = null, int? timeout = null)
        {
            Category? result;
            try
            {
                if (id == null) return null;
                result = categoryRepository.Delete(new Category { Id = id }, transaction, timeout);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("CategoryService.Delete", id, transaction, timeout));
                throw;
            }
            return result;
        }

        public Category? GetById(long? id)
        {
            Category? result;
            try
            {
                if (id == null) return null;
                result = categoryRepository.GetById(id);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("CategoryService.GetById", id));
                throw;
            }
            return result;
        }
    }
}
