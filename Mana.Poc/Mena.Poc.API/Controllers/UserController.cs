//using Mena.Poc.Domain.Interfaces.Service;
using Mena.Poc.Domain.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mena.Poc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private readonly IUserService _userService;
        //public UserController(IUserService userService)
        //{
        //    _userService = userService;
            
        //}
        //[HttpGet]
        //[Route("GetAllUser")]
        //public IEnumerable<User> GetAllUser()
        //{
        //    return _userService.GetAllUsers().Result;
        //}
    }
}
