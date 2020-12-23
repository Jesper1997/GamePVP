using IModel.Items;
using System;
using System.Collections.Generic;
using System.Text;
using Model.Items;
using IModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Model
{
    public class Character : ICharacter
    {
        [Key]
        public int id { get; set; }
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
        [JsonIgnore]
        public User User { get; set; }

        List<IEquipment> GetEquipment => converEquipment();
        public List<Equipment> Equipment { get; set; }
        

        public Character()
        {
            this.Equipment = new List<Equipment>();
        }

        private List<IEquipment> converEquipment()
        {
            List<IEquipment> equipment = new List<IEquipment>();
            foreach(Equipment equip in Equipment)
            {
                equipment.Add(equip);
            }
            return equipment;
        }
    }
}
