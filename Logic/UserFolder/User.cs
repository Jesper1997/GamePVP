using System;
using System.Collections.Generic;
using System.Text;
using ILogic.IUserFolder;

namespace Logic.UserFolder
{
    class User : IUser
    {
        public ICharacter UsedCharacter { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }

        public void Login(string name, string pW)
        {
            throw new NotImplementedException();
        }
    }
}
