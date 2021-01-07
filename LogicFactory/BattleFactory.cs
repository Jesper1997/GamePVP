using System;
using System.Collections.Generic;
using System.Text;
using Logic;
using Dal;

namespace LogicFactory
{
    public class BattleFactory
    {
        // dalfactory aan roepen en dal meegeven
        public BattleManager Battle => new BattleManager(new DalBattle());
    }
}
