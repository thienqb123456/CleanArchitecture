using Application.Services.Cms.Interfaces;
using Domain.Entities.Cms;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using static Application.Utilities.LogUtility;


namespace WebApi.Controllers.Cms
{
    [Route("api/category", Name = "Cms - Category")]
    [ApiController]
    public class CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Create([FromBody] Category category)
        {
            dynamic result = new ExpandoObject();
            try
            {
                var response = categoryService.Create(category);
                if (response == null) return Problem();
                result.item = response;
                return Ok(result);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("CategoryController.Create", category));
                return BadRequest(result);
            }
        }

        [HttpPatch]
        public IActionResult Update([FromBody] Category category)
        {
            dynamic result = new ExpandoObject();
            try
            {
                var response = categoryService.Update(category);
                if (response == null) return Problem();
                result.item = response;
                return Ok(result);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("CategoryController.Update", category));
                return BadRequest(result);
            }
        }

        [HttpDelete]
        public IActionResult Delete(long id)
        {
            dynamic result = new ExpandoObject();
            try
            {
                var response = categoryService.Delete(id);
                if (response == null) return Problem();
                result.item = response;
                return Ok(result);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, Message("CategoryController.Delete", id));
                return BadRequest(result);
            }
        }

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
