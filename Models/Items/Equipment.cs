using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using IModel.Items;

namespace Model.Items
{
    public class Equipment : Item, IEquipment
    {
        [Key]
        public int id { get; set; }
        public List<Attack> Attacks { get; set; }

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
