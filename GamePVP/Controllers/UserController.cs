using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LogicFactory;
using ILoigc;

namespace GamePVP.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        private UserManagerFactory _userManagerFactory;


        [HttpPost]
        [Route("CreateCharacter")]
        public IActionResult CreateCharacter(ViewModels.UserViewModel userView)
        {
            _userManagerFactory = new UserManagerFactory();
            IUserManager userManager = _userManagerFactory.UserManager;
            return Ok(value: userManager.CreateCharacter(userView.character.MaxHP, userView.character.BaseAttack, userView.character.BaseSpecialAttack, userView.character.BaseDefence, userView.character.BaseAgility, userView.id));
        }
    }
}
