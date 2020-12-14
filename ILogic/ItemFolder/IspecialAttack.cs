using System;
using System.Collections.Generic;
using System.Text;

namespace ILogic.ItemFolder
{
    public interface IspecialAttack
    {
        public string Name { get; set; }
        public string AttackType { get; set; }
        public int AttackMutiplier { get; set; }
        public int BaseAccuracy { get; set; }
    }
}
