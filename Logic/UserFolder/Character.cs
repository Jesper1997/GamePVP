using System;
using System.Collections.Generic;
using System.Text;
using IDal.DTO.DTOUserFolder;
using ILogic.IUserFolder;
using ILogic.ItemFolder;
using Logic.ItemsFolder;

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
        public IUser User { get; set; }

        public List<IEquipment> Equipment { get; set; }


        public Character()
        {
            this.Equipment = new List<IEquipment>();
            IspecialAttack ispecial = new SpecialAttack
            {
                AttackMutiplier = 1,
                AttackType = "attack",
                BaseAccuracy = 90,
                Name = "fist"
            };
            IEquipment equipment = new Equipment();
            equipment.SpecialAttacks.Add(ispecial);
            this.Equipment.Add(equipment);

        }

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
