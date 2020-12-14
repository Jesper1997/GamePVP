using System;
using System.Collections.Generic;
using System.Text;

namespace ILogic.ItemFolder
{
    public interface IEquipment : IItem
    {
        public List<IspecialAttack> SpecialAttacks { get; set; }
    }
}
