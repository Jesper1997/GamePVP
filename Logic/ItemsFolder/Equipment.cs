using ILogic.ItemFolder;
using Logic.ItemsFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.ItemsFolder
{
    public class Equipment : Item, IEquipment
    {
        public Equipment()
        {
            SpecialAttacks = new List<IspecialAttack>();
        }

        public List<IspecialAttack> SpecialAttacks { get; set; }

    }
}
