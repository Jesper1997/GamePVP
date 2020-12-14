using System;
using Logic.UserFolder;

namespace LogicFactory
{
    public class UserFolderFactory
    {
        public UserManager UserManager => new UserManager();
        public User User => new User();
        public Character Character => new Character();
    }
}
