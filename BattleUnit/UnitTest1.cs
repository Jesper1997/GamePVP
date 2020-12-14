using System;
using Xunit;
using GamePVP.Controllers;
using GamePVP.ViewModels;
using System.Collections.Generic;
using GamePVP.ViewModels.ItemsViewModel;
using ILogic;

namespace BattleUnit
{
    public class UnitTest1
    {
        [Fact]
        public void BattleTest()
        {
            BattleViewModel battleView = new BattleViewModel
            {
                PlayersTurn = 0,
                AttackMove = "Fist",

                characterViewModels = new List<CharacterViewModel>
                {
                    new CharacterViewModel
                    {
                        HP = 100,
                        MaxHP = 100,
                        AgilityTotalValue = 5,
                        BaseAgility = 5,
                        BaseAttack = 10,
                        AttackTotalValue = 10,
                        BaseSpecialAttack = 20,
                        SpecialAttackTotlaValue = 20,
                        BaseDefence = 10,
                        DefenceTotalValue = 10,
                        Equipment = new List<GamePVP.ViewModels.ItemsViewModel.EquipmentViewModel>
                        {
                            new EquipmentViewModel
                            {
                                specialAttacks = new List<SpecialAttackViewModel>
                                {
                                    new SpecialAttackViewModel
                                    {
                                        AttackMutiplier = 1,
                                        AttackType = "attack",
                                        BaseAccuracy = 90,
                                        Name = "fist"
                                    }
                                }
                            }
                        }

                    },
                    new CharacterViewModel
                    {
                        HP = 100,
                        MaxHP = 100,
                        AgilityTotalValue = 5,
                        BaseAgility = 5,
                        BaseAttack = 10,
                        AttackTotalValue = 10,
                        BaseSpecialAttack = 20,
                        SpecialAttackTotlaValue = 20,
                        BaseDefence = 10,
                        DefenceTotalValue = 10,
                        Equipment = new List<GamePVP.ViewModels.ItemsViewModel.EquipmentViewModel>
                        {
                            new EquipmentViewModel
                            {
                                specialAttacks = new List<SpecialAttackViewModel>
                                {
                                    new SpecialAttackViewModel
                                    {
                                        AttackMutiplier = 1,
                                        AttackType = "attack",
                                        BaseAccuracy = 90,
                                        Name = "fist"
                                    }
                                }
                            }
                        }
                    }
                }
                
                
            };
            BattleController battleController = new BattleController();
            IBattle battle = (IBattle)battleController.Battle(battleView);
            
        }
    }
}
