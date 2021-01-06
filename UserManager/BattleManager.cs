using System;
using System.Collections.Generic;
using System.Text;
using ModelFactory;
using ILoigc;
using IModel;
using DalFactory;
using IDal;
using Model;
using Model.Items;

namespace Logic
{
    public class BattleManager: IBattleManager
    {
        private BattleRelatedFactory _battleFactory;
        private DalBattleFactroy _dalBattleFactory;

        public IBattle EnterBattle(int characterid)
        {
            _dalBattleFactory = new DalBattleFactroy();
            IDalBattle dalBattle = _dalBattleFactory.DalBattle;
            Character character = dalBattle.GetCharacterbyid(characterid);
            List<Battle> battles = dalBattle.GetAllBattles();
            //Pointtotal opslaan bij character?
            int pointtotal = character.AgilityTotalValue + character.AttackTotalValue + character.AttackTotalValue + character.SpecialAttackTotlaValue;
            if (battles.Count <= 0)
            {
                foreach(Battle battle in battles)
                {
                    if (battle.PlayerSkillPoints +2 >=  pointtotal && battle.PlayerSkillPoints - 2 <= pointtotal)
                    {
                        battle.IFighters.Add(character);
                        dalBattle.UpdateBattle(battle);
                        return battle;
                    }
                }
                return Createbattle(pointtotal, character, dalBattle);
            }
            else
            {
                return Createbattle(pointtotal, character, dalBattle);
            }
        }

        private IBattle Createbattle(int totalpoints, Icharacter character, IDalBattle dalBattle)
        {
            _battleFactory = new BattleRelatedFactory();
            IBattle battle = _battleFactory.CreateBattle;
            battle.IFighters.Add(character);
            battle.PlayerSkillPoints = totalpoints;
            dalBattle.insertBattle(battle);
            return battle;
        }
        
        //TODO: Controle of speler de aanval wel kan uitvoeren. of wel kijken of character wel de juiste equipment bezit
        public IBattle excuteHostileAction(int battleid, int attackid)
        {
            _dalBattleFactory = new DalBattleFactroy();
            IDalBattle dalBattle = _dalBattleFactory.DalBattle;
            IBattle battle = dalBattle.GetBattleById(battleid);
            Attack attack = dalBattle.GetAttackById(attackid);
            Icharacter character = battle.IFighters[battle.playersturn];
            Icharacter getattacked;
            if(battle.playersturn == 0)
            {
                getattacked = battle.IFighters[1];
            }
            else
            {
                getattacked = battle.IFighters[0];
            }
            if(attack.AttackType == "attack")
            {
                Attack(character.AttackTotalValue, getattacked, attack);
            }
            else if(attack.AttackType == "specialattack")
            {
                Attack(character.AttackTotalValue, getattacked, attack);
            }
            dalBattle.UpdateBattle(battle);
            return battle;
        }

        private void Attack(int attacks, Icharacter getsattacked, Attack attack)
        {
            Random r = new Random();
            if (r.Next(0, 100) < attack.BaseAccuracy)
            {
                if (r.Next(0, 100) > (getsattacked.AgilityTotalValue / 2))
                {
                    getsattacked.HP -= attacks;
                }
                else return;
            }
            else return;
        }
    }
}
