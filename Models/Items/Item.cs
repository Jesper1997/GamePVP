using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using IModel.Items;

namespace Model.Items
{
    public class Item : IItems
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int SpecialAttack { get; set; }
        public int Agility { get; set; }
        public int Price { get; set; }
    }
}
