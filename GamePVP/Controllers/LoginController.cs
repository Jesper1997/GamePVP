using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using ILoigc;
using LogicFactory;

namespace GamePVP.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LoginController : ControllerBase
    {
        private Encoding encoding = new Encoding();
        private UserManagerFactory _userManagerFactory;

        [HttpPost]
        [Route("Registreer")]
        public IActionResult Registreer([FromBody] ViewModels.RegistreerViewModel registreer)
        {
            _userManagerFactory = new UserManagerFactory();
            IUserManager userManager = _userManagerFactory.UserManager;
            return Ok(value: userManager.CreateUser(registreer.Name, encoding.StrToByte(registreer.Pw), encoding.StrToByte(registreer.PwCheck)));
        }


        [HttpGet]
        [Route("Login")]
        public IActionResult Login([FromBody] ViewModels.LoginViewModel login)
        {
            _userManagerFactory = new UserManagerFactory();
            IUserManager userManager = _userManagerFactory.UserManager;

            return Ok(value: userManager.LoginUser(login.Name, encoding.StrToByte(login.Pw)));
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAllUser()
        {
            _userManagerFactory = new UserManagerFactory();
            IUserManager userManager = _userManagerFactory.UserManager;
            return Ok(value: userManager.GetUsers());
        }
    }
}
