using System;
using ILoigc;
using IModel;
using IDal;
using ModelFactory;
using DalFactory;
using System.Collections.Generic;
using Model;

namespace Logic
{
    public class UserManager : IUserManager
    {
        private UserRelatedModelFactory _modelFactory;
        private DalUserFactory _dalFactory;

        public IUser CreateCharacter(int HP, int Attack, int SpecialAttack, int Defence, int Agilety, int id)
        {
            User user = GetUserById(id);
            Character character = new Character
            {
                MaxHP = HP,
                HP = HP,
                BaseAttack = Attack,
                AttackTotalValue = Attack,
                BaseDefence = Defence,
                DefenceTotalValue = Defence,
                BaseSpecialAttack = SpecialAttack,
                SpecialAttackTotlaValue = SpecialAttack,
                BaseAgility = Agilety,
                AgilityTotalValue = Agilety,
                User = user
            };
            user.Characters.Add(character);

            _dalFactory = new DalUserFactory();
            IDalUser dalUser = _dalFactory.DalUser;
            dalUser.UpdateUser(user); ;
            
            return user;
        }

        public IUser CreateUser(string name, string pw, string pwCheck)
        {

            if(pw == pwCheck)
            {
                _modelFactory = new UserRelatedModelFactory();
                IUser user = _modelFactory.CreateUser();
                user.name = name;
                user.Pw = pw;

                _dalFactory = new DalUserFactory();
                IDalUser dalUser = _dalFactory.DalUser;
                dalUser.InsertUser(user);
                return user;
            }
            else
            {
                return null;
            }
        }

        public List<IUser> GetUsers()
        {
            _dalFactory = new DalUserFactory();
            IDalUser dalUser = _dalFactory.DalUser;
            return dalUser.GetUsers();
        }

        public IUser LoginUser(string name, string pw)
        {
            _dalFactory = new DalUserFactory();
            IDalUser dalUser = _dalFactory.DalUser;
            return (dalUser.LoginUser(name, pw));
        }

        private User GetUserById(int id)
        {
            _dalFactory = new DalUserFactory();
            IDalUser dalUser = _dalFactory.DalUser;
            return dalUser.GetUSerById(id);  
        }
    }
}
