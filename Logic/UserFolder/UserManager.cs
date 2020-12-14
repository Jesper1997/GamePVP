using System;
using ILogic.IUserFolder;
using IDal.DTO.DTOUserFolder;
using IDal.Interface;
using DalFactoty;
using System.Collections.Generic;

namespace Logic.UserFolder
{
    public class UserManager : IUsermanger
    {
        private protected UserDALFactory factory;
        public IUser CreateUser(string name, string pw, string pWCheck)
        {
            if(pw == pWCheck)
            {
                User user = new User {Name = name, PW = pw };
                DTOUser dTOUser = new DTOUser { Name = user.Name, PW = user.PW };
                UserDALFactory factory = new UserDALFactory();
                IUserDAL IUserDAL = factory.GetDalUser();
                IUserDAL.InsertUser(dTOUser);
                return user;
            }
            else
            {
                return null;
            }
        }

        public IUser Login(string name, string pW)
        {
            //DTOUser dTOUser = new DTOUser { Name = name, PW = pW };
            UserDALFactory factory = new UserDALFactory();
            IUserDAL IUserDAL = factory.GetDalUser();
            var dTOuser = IUserDAL.GetUser(name, pW);
            var user = ConvertDTOUserToUser(dTOuser);
            return user;
        }

        public User ConvertDTOUserToUser(DTOUser dTOUser)
        {
            if(dTOUser == null)
            {
                return null;
            }
            User user = new User();
            user.Name = dTOUser.Name;
            user.Points = dTOUser.Points;
            if(dTOUser.Chachters == null)
            {
                return user;
            }
            foreach(DTOCharacter character in dTOUser.Chachters)
            {
                Character chara = new Character();
                chara.AgilityTotalValue = character.AgilityTotalValue;
                chara.AttackTotalValue = character.AttackTotalValue;
                chara.BaseAgility = character.BaseAgility;
                chara.BaseAttack = character.BaseAttack;
                chara.BaseDefence = character.BaseDefence;
                chara.BaseSpecialAttack = character.BaseSpecialAttack;
                chara.DefenceTotalValue = character.DefenceTotalValue;
                chara.HP = character.HP;
                chara.MaxHP = character.MaxHP;
                user.characters.Add(chara);
            }
            return user;
        }
    }
}
