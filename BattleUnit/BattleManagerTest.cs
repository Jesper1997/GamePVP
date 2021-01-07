using System;
using Xunit;
using GamePVP.Controllers;
using GamePVP.ViewModels;
using System.Collections.Generic;
using GamePVP.ViewModels.ItemsViewModel;
using Logic;
using IDal;
using Model;
using Model.Items;
using IModel;

namespace BattleUnit
{
    public class BattleManagerTest
    {
        //match making
        //Matchmaking works finds a match
        [Fact]
        public void BattleMatchMakingfortyPointsTest()
        {
            BattleManager battle = new BattleManager();
            battle.EnterBattle(0, new DummyDAL());
            Battle bat = (Battle)battle.EnterBattle(0, new DummyDAL());
            Assert.True(bat.id == 3);
            Assert.False(bat.IFighters.Count == 1);
        }
        //Test out to many skillpoints
        [Fact]
        public void BattleMAtchMakingeightySkillPoints()
        {
            BattleManager battle = new BattleManager();
            Battle bat = (Battle)battle.EnterBattle(5, new DummyDAL());
            Assert.True(bat.IFighters.Count == 1);
            Assert.Equal(80, bat.PlayerSkillPoints);
        }

        //test limit of skill points
        [Fact]
        public void BAttleMatchMakingFortytwoSkilpoints()
        {
            BattleManager battle = new BattleManager();
            Battle bat = (Battle)battle.EnterBattle(6, new DummyDAL());
            Assert.False(bat.IFighters.Count == 1);
            Assert.True(bat.id == 3);
            Assert.Equal(12, bat.Fighters[1].id);
        }


        public class DummyDAL : IDalBattle
        {
            public List<Character> characters = new List<Character>
            {
                new Character { id = 6 , AgilityTotalValue = 10, AttackTotalValue = 10, SpecialAttackTotlaValue = 10, DefenceTotalValue = 10 },
                new Character { id = 7},
                new Character { id = 8},
                new Character { id = 9},
                new Character { id = 10},
                new Character { id = 11, AgilityTotalValue = 20, AttackTotalValue =20, DefenceTotalValue = 20, SpecialAttackTotlaValue = 20},
                new Character { id = 12, AgilityTotalValue = 11, AttackTotalValue = 11, DefenceTotalValue = 10, SpecialAttackTotlaValue = 10}
            };
            public List<Battle> battles = new List<Battle>
            {
                new Battle { id = 1, PlayerSkillPoints = 40 },
                new Battle { id = 2, PlayerSkillPoints = 20 },
                new Battle { id = 3, PlayerSkillPoints = 40 },
            };

            public List<Battle> GetAllBattles()
            {
                battles[0].Fighters.Add(characters[1]);
                battles[0].Fighters.Add(characters[2]);
                battles[1].Fighters.Add(characters[3]);
                battles[1].Fighters.Add(characters[4]);
                battles[2].Fighters.Add(characters[2]);
                return battles;
            }

            public Attack GetAttackById(int id)
            {
                throw new NotImplementedException();
            }

            public Battle GetBattleById(int id)
            {
                throw new NotImplementedException();
            }

            public Character GetCharacterbyid(int id)
            {
                return characters[id];
            }

            public void insertBattle(IBattle battle)
            {
                battles.Add((Battle)battle);
            }

            public void UpdateBattle(IBattle battle)
            {
                int removeid = 99;
                foreach(Battle bat in battles)
                {
                    if(battle.IFighters[0] == bat.IFighters[0])
                    {
                        removeid = battles.IndexOf(bat);
                    }
                }
                battles.RemoveAt(removeid);
                battles.Add((Battle)battle);
            }
        }
    }
}
