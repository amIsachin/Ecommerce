using Application.Repositories.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region DependencyInjection
        private readonly IRepository<UserEntity> _userRepository;

        public UserController(IRepository<UserEntity> userRepository)
        {
            _userRepository = userRepository;
        }
        #endregion


        /// <summary>
        /// Get all users.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetAllUsers()
        {
            var allUsers = await _userRepository.GetAllAsync();

            if (allUsers != null)
            {
                return Ok(allUsers);
            }

            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }
    }
}
