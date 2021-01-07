using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicFactory;
using ILoigc;
using Microsoft.AspNetCore.Mvc;

namespace GamePVP.Controllers
{
    [Route("[Controller]")]
    public class BattleController : ControllerBase
    {
        private BattleFactory _battleFactory;

        [HttpGet]
        [Route("ExecuteAttack")]
        //Dit gaan doen met ID en een actie zo min mogelijk in fomatie op en neer sturen
        public IActionResult ExecuteAttack([FromBody] ViewModels.BattleViewModel battle)
        {
            IBattleManager battleManager = _battleFactory.Battle;
            return Ok(battleManager.excuteHostileAction(battle.battleid, battle.Attackid));
        }

        [HttpGet]
        [Route("LookForBattle/{id}")]
        public IActionResult LookForBattle([FromRoute] int id)
        {

            return Ok();
        }
    }
}
