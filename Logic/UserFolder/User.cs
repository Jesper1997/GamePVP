using System;
using System.Collections.Generic;
using System.Text;
using ILogic.IUserFolder;

namespace Logic.UserFolder
{
    public class User : IUser
    {
        public ICharacter UsedCharacter { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public List<ICharacter> characters { get; set; }
        public string PW { get; set; }

        public IUser CreateCharacter(int HP, int Attack, int SpecialAttack, int Defence, int Agility, IUser user)
        {
            //TODO injection
            //Character character = new Character { MaxHP = HP, BaseAttack = Attack, BaseSpecialAttack = SpecialAttack, BaseDefence = Defence, BaseAgility = Agility, User = user };
            DalFactoty.UserDALFactory factory = new DalFactoty.UserDALFactory();
            IDal.Interface.IUserDAL userDAL = factory.GetDalUser();
            userDAL.InserCharacter(new IDal.DTO.DTOUserFolder.DTOCharacter { BaseAgility = Agility, BaseAttack = Attack, BaseSpecialAttack = SpecialAttack, BaseDefence = Defence, MaxHP = HP, DTOUser = new IDal.DTO.DTOUserFolder.DTOUser { Name = user.Name } });
            //UsedCharacter = character;
            //characters.Add(character);
            return user;
        }

    }
}
