using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamePVP.ViewModels.ItemsViewModel
{
    public class EquipmentViewModel: ItemViewModel
    {
        public List<SpecialAttackViewModel> specialAttacks { get; set; }
    }
}
