using System;
using System.Collections.Generic;
using IModel;

namespace ILoigc
{
    public interface IUserManager
    {
        public IUser CreateUser(string name, string pw, string pwCheck);
        public IUser LoginUser(string name, string pw);
        public List<IUser> GetUsers();
        public IUser CreateCharacter(int HP, int Attack, int SpecialAttack, int Defence, int Agilety, int id);
    }
}
