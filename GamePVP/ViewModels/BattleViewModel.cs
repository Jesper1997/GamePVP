using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamePVP.ViewModels
{
    public class BattleViewModel
    {
        public List<CharacterViewModel> characterViewModels { get; set; }
        public string AttackMove { get; set; }
        public int PlayersTurn { get; set; }
    }
}
