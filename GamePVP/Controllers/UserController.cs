using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using LogicFactory;
using ILogic.IUserFolder;

namespace GamePVP.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        
        [HttpPost]
        [Route("CreateCharacter")]
        public IActionResult CreateCharacter(ViewModels.UserViewModel userView)
        {
            UserFolderFactory factory = new UserFolderFactory();
            IUser user = factory.User;
            user.Name = userView.Name;
            user.CreateCharacter(userView.character.MaxHP, userView.character.BaseAttack, userView.character.BaseSpecialAttack, userView.character.DefenceTotalValue, userView.character.BaseAgility, user);
            return Ok(user);
        }
    }
}
