using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using referenceCaseWebApp.Model;
using referenceCaseWebApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace referenceCaseWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository categoryRepository { get; set; }
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Category> categories = categoryRepository.GetCategories();
            return Ok(categories);
        }
    }
}
