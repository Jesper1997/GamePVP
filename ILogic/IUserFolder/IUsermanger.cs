using System;

namespace ILogic.IUserFolder
{
    public interface IUsermanger
    {
        public IUser CreateUser(string name, string pw, string pWCheck);
        public IUser Login(string name, string pW);
    }
}
