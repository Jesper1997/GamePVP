using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamePVP.ViewModels.ItemsViewModel
{
    public class SpecialAttackViewModel
    {
        public string Name { get; set; }
        public string AttackType { get; set; }
        public int AttackMutiplier { get; set; }
        public int BaseAccuracy { get; set; }
    }
}
