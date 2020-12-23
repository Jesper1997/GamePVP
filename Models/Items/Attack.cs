using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using IModel.Items;

namespace Model.Items
{
    public class Attack : IAttack
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string AttackType { get; set; }
        public int AttackMutiplier { get; set; }
        public int BaseAccuracy { get; set; }
    }
}
