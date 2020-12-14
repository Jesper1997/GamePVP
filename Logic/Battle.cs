using System;
using System.Collections.Generic;
using System.Text;
using ILogic;
using ILogic.IUserFolder;
using Logic.ItemsFolder;

namespace Logic
{
    public class Battle : IBattle
    {
        public List<ICharacter> characters { get; set; }

        public void ExecuteAttack(string attackname, int playerturn)
        {
            //foreach (Equipment equipment in characters[playerturn]. )
            {
            }
        }
    }
}
