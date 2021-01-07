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
        BattleRelatedFactory _battleFactory;
        IDalBattle _dalBattle;
        //injection via constructor
        public BattleManager(IDalBattle dalBattle)
        {
            _dalBattle = dalBattle;

        }

        public IBattle EnterBattle(int characterid)
        {
            Character character = _dalBattle.GetCharacterbyid(characterid);
            List<Battle> battles = _dalBattle.GetAllBattles();
            //Pointtotal opslaan bij character?
            int pointtotal = character.AgilityTotalValue + character.AttackTotalValue + character.DefenceTotalValue + character.SpecialAttackTotlaValue;
            if (battles.Count >= 0)
            {
                foreach(Battle battle in battles)
                {
                    if (battle.PlayerSkillPoints +2 >=  pointtotal && battle.PlayerSkillPoints - 2 <= pointtotal && battle.IFighters.Count == 1)
                    {
                        battle.InsertFighter(character);
                        _dalBattle.UpdateBattle(battle);
                        return battle;
                    }
                }
                return Createbattle(pointtotal, character);
            }
            else
            {
                return Createbattle(pointtotal, character);
            }
        }

        private IBattle Createbattle(int totalpoints, Icharacter character)
        {
            _battleFactory = new BattleRelatedFactory();
            IBattle battle = _battleFactory.CreateBattle;
            battle.InsertFighter(character);
            battle.PlayerSkillPoints = totalpoints;
            _dalBattle.insertBattle(battle);
            return battle;
        }
        
        //TODO: Controle of speler de aanval wel kan uitvoeren. of wel kijken of character wel de juiste equipment bezit
        public IBattle excuteHostileAction(int battleid, int attackid)
        {
            IBattle battle = _dalBattle.GetBattleById(battleid);
            Attack attack = _dalBattle.GetAttackById(attackid);
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
            _dalBattle.UpdateBattle(battle);
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
