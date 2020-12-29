using System.Collections.Generic;
using System.Text.Json.Serialization;
using IModel.Items;

namespace Model.Items
{
    public class Equipment : Item, IEquipment
    {
        public List<Attack> Attacks { get; set; }
        [JsonIgnore]
        public List<IAttack> GetAttacks => ConverAttacks();

        public Equipment()
        {
            Attacks = new List<Attack>();
        }

        private List<IAttack> ConverAttacks()
        {
            List<IAttack> attacks = new List<IAttack>();
            foreach(Attack attack in Attacks )
            {
                IAttack convert = attack;
                attacks.Add(convert);
            }
            return attacks;
        }


    }
}
