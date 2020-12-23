using System;
using System.Collections.Generic;
using System.Text;

namespace IModel.Items
{
    public interface IEquipment
    {
        public List<IAttack> GetAttacks { get; }
    }
}
