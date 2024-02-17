using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using static Application.Utilities.LogUtility;


namespace WebApi.Controllers
{
    [Route("api/category", Name = "Category")]
    [ApiController]
    public class CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService) : ControllerBase
    {
        [HttpGet("{id:long}")]
        public IActionResult GetById(long id)
        {
            dynamic result = new ExpandoObject();
            try
            {
                var response = categoryService.GetById(id);
                if (response == null) return NotFound();
                result.item = response;
                return Ok(result);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("CategoryController.GetById", id));
                return BadRequest(result);
            }
        }
    }
}
