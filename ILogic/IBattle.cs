using System;
using System.Collections.Generic;
using System.Text;
using ILogic.IUserFolder;

namespace ILogic
{
    public interface IBattle
    {
        public List<ICharacter> characters { get; set; }

        public void ExecuteAttack(string attackname, int playersturn)
        {
            //foreach(string specialattckname in characters[playersturn].)
        }
    }
}
