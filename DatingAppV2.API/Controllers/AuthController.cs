using DatingAppV2.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace DatingAppV2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repos;
        public AuthController(IAuthRepository repo)
        {
            _repos = repo;
        }
        
    }
}