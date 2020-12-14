using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LogicFactory;
using ILogic;
using ILogic.IUserFolder;


namespace GamePVP.Controllers
{
    [Route("[Controller]")]
    public class BattleController : ControllerBase
    {
        [Route("Battle")]
        //Dit gaan doen met ID en een actie zo min mogelijk in fomatie op en neer sturen
        public IActionResult Battle(int id, string actie )
        {
            BattleFactory battleFactory = new BattleFactory();
            IBattle battle = battleFactory.GetBattle();
            UserFolderFactory factory = new UserFolderFactory();
            foreach(ViewModels.CharacterViewModel charactermodel in battleViewModel.characterViewModels)
            {
                ICharacter character = factory.Character;
                character = (ICharacter)charactermodel;
            }

            //battle.characters = battleViewModel.characterViewModels.Cast<ICharacter>().ToList();
            battle.ExecuteAttack(battleViewModel.AttackMove, battleViewModel.PlayersTurn);
            return Ok(battle);
        }
    }
}
