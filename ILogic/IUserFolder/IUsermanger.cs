using System;

namespace ILogic.IUserFolder
{
    public interface IUsermanger
    {
        public bool CreateUser(string name, string pw, string pWCheck);
    }
}
