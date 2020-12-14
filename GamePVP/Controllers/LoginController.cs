using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace GamePVP.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LoginController : ControllerBase
    {
        private Encoding encoding = new Encoding();
        private LogicFactory.UserFolderFactory factory;

        [HttpPost]
        [Route("Registreer")]
        public IActionResult Registreer([FromBody] ViewModels.RegistreerViewModel registreer)
        {
            //ViewModels.RegistreerViewModel registreer = data;
            factory = new LogicFactory.UserFolderFactory();
            ILogic.IUserFolder.IUsermanger usermanger = factory.UserManager;
            //byte pW = Convert.ToByte(registreer.Pw);
            ILogic.IUserFolder.IUser user = usermanger.CreateUser(registreer.Name,encoding.StrToByte(registreer.Pw), encoding.StrToByte(registreer.PwCheck));

            return Ok(value: user);
        }

        [HttpGet]
        [Route("Login")]
        public IActionResult Login ([FromBody] ViewModels.LoginViewModel login)
        {
            factory = new LogicFactory.UserFolderFactory();
            ILogic.IUserFolder.IUsermanger usermanger = factory.UserManager;
            encoding = new Encoding();           
            return Ok(usermanger.Login(login.Name, encoding.StrToByte(login.Pw)));
        }
    }
}
