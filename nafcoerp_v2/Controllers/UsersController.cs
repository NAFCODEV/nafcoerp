using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nafcoerp_v2.Models;
using nafcoerp_v2.Services;

namespace nafcoerp_v2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserServices _uss = new UserServices();
        [HttpGet]
         public List<UserModel> Get() => _uss.getAlluser();
      
    }
}
