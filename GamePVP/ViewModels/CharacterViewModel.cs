using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamePVP.ViewModels.ItemsViewModel;

namespace GamePVP.ViewModels
{
    public class CharacterViewModel
    {
        public int MaxHP { get; set; }
        public int BaseAttack { get; set; }
        public int BaseDefence { get; set; }
        public int BaseSpecialAttack { get; set; }
        public int BaseAgility { get; set; }
    }
}
