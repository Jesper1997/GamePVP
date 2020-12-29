using System;
using System.Collections.Generic;
using System.Text;
using Model;
using IModel;
using Model.Items;

namespace IDal
{
    public interface IDalBattle
    {
        List<Battle> GetAllBattles();
        void UpdateBattle(IBattle battle);
        void insertBattle(IBattle battle);
        Battle GetBattleById(int id);
        Attack GetAttackById(int id);
        Character GetCharacterbyid(int id);
    }
}
