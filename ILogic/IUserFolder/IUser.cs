using System;
using System.Collections.Generic;
using System.Text;

namespace ILogic.IUserFolder
{
    public interface IUser
    {
        List<ICharacter> characters { get; set; } 
        public string Name { get; set; }
        public int Points { get; set; }

        public IUser CreateCharacter(int HP, int Attack, int SpecialAttack, int Defence, int Agilety, IUser user);
    }
}
