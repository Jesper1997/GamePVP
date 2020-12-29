using IModel.Items;
using System.Collections.Generic;

namespace IModel
{
    public interface @int
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
        public List<IEquipment> GetEquipment { get; }
    }
}
