using System;
using System.Collections.Generic;
using System.Text;
using ILogic.IUserFolder;

namespace Logic.UserFolder
{
    public class Character : ICharacter
    {
        public int MaxHP { get ; set ; }
        public int HP { get; set; }
        public int AttackTotalValue { get; set; }
        public int BaseAttack { get; set; }
        public int DefenceTotalValue { get; set; }
        public int BaseDefence { get; set; }
        public int SpecialAttackTotlaValue { get; set; }
        public int BaseSpecialAttack { get; set; }
        public int AgilityTotalValue { get; set; }
        public int BaseAgility { get; set; }

        public void AttackTheOpponent()
        {
            throw new NotImplementedException();
        }

        public void EquipItem(string NameItem)
        {
            throw new NotImplementedException();
        }
    }
}
