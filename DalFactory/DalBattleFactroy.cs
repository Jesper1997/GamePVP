using System;
using System.Collections.Generic;
using System.Text;
using Dal;

namespace DalFactory
{
    public class DalBattleFactroy
    {
        public DalBattle DalBattle => new DalBattle();
    }
}
