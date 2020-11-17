using System;
using System.Collections.Generic;
using System.Text;

namespace ILogic.IUserFolder
{
    public interface IUser
    {
        public ICharacter UsedCharacter { get; set; }
        public string Name { get; set; }

        public int Points { get; set; }

        public void Login(string name, string pW);

    }
}
