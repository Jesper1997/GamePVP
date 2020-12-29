using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace ModelFactory
{
    public class BattleRelatedFactory
    {
        public Battle CreateBattle => new Battle();
    }
}
