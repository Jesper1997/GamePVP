using System;
using System.Collections.Generic;
using System.Text;
using IModel;
using IDal;

namespace ILoigc
{
    public interface IBattleManager
    {
        public IBattle EnterBattle(int characterid);
        public IBattle excuteHostileAction(int battleid, int attackid);
    }
}
