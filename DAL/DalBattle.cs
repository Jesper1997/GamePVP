using System;
using System.Collections.Generic;
using System.Text;
using IDal;
using IModel;
using Model;
using Model.Items;

namespace Dal
{
    public class DalBattle : IDalBattle
    {
        public List<Battle> GetAllBattles()
        {
            using (var context = new DBCreate())
            {
                var dbBattle = context.Battles;
                if (dbBattle == null)
                {
                    return null;
                }
                List<Battle> battles = new List<Battle>();
                foreach(var battle in dbBattle)
                {
                    battles.Add(battle);
                }
                return battles;
            }
        }

        public Attack GetAttackById(int id)
        {
            using (var context = new DBCreate())
            {
                Attack attack = context.attacks.Find(id);
                return attack;
            }
        }

        public Battle GetBattleById(int id)
        {
            using (var context = new DBCreate())
            {
                Battle battle = context.Battles.Find(id);
                return battle;
            }
        }

        public Character GetCharacterbyid(int id)
        {
            using (var context = new DBCreate())
            {
                Character character = context.character.Find(id);
                return character;
            }
        }

        public void insertBattle(IBattle battle)
        {
            using (var context = new DBCreate())
            {
                context.EnsureDbIsCreated();
                context.Battles.Add((Battle)battle);
                context.SaveChanges();
            }
        }

        public void UpdateBattle(IBattle battle)
        {
            using (var context = new DBCreate())
            {
                context.EnsureDbIsCreated();
                context.Battles.Update((Battle)battle);
                context.SaveChanges();
            }
        }
    }
}
