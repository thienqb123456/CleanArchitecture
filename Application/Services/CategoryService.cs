using Application.IRepositories;
using Application.Services.Implements;
using Application.Services.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class CategoryService(ILogger<CategoryService> logger, ICategoryRepository categoryRepository) : BaseService<Category>(logger, categoryRepository), ICategoryService
    {
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
