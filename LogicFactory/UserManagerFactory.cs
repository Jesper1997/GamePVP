using System;
using Logic;

namespace LogicFactory
{
    public class UserManagerFactory
    {
        public UserManager UserManager => new UserManager();
    }
}
