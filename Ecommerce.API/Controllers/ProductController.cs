using Application.Repositories.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region DependencyInjection
        private readonly IRepository<ProductEntity> _productRepository;

        public ProductController(IRepository<ProductEntity> repository)
        {
            _productRepository = repository;
        }
        #endregion


        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<IActionResult> GetAllProducts()
        {
            var allProducts = await _productRepository.GetAllAsync();

            if (allProducts != null)
            {
                return Ok(allProducts);
            }

            return new StatusCodeResult(StatusCodes.Status500InternalServerError);

        }
    }
}
