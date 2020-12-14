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
        public int HP { get; set; }
        public int AttackTotalValue { get; set; }
        public int BaseAttack { get; set; }
        public int DefenceTotalValue { get; set; }
        public int BaseDefence { get; set; }
        public int SpecialAttackTotlaValue { get; set; }
        public int BaseSpecialAttack { get; set; }
        public int AgilityTotalValue { get; set; }
        public int BaseAgility { get; set; }

        public List<EquipmentViewModel> Equipment { get; set; }

        public static T Cast<T>(this object myobje)
        {
            Type objectType = myobje.GetType();
            Type target = typeof(T);
            var x = Activator.CreateInstance(target, false);
            var z = from source in objectType.GetMembers().ToList()
                    where source.MemberType == System.Reflection.MemberTypes.Property select source;
            var d = from source in target.
            return (T)
        }
    }
}
