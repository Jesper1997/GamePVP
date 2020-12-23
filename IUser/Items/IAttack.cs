using System;
using System.Collections.Generic;
using System.Text;

namespace IModel.Items
{
    public interface IAttack
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string AttackType { get; set; }
        public int AttackMutiplier { get; set; }
        public int BaseAccuracy { get; set; }
    }
}
