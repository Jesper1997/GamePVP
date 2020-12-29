using System;
using System.Collections.Generic;
using IModel;
using Model;
using Model.Items;

namespace IDal
{
    public interface IDalUser
    {
        public void InsertUser(IUser user);
        public IUser LoginUser(string name, string pw);
        public List<IUser> GetUsers();
        public User GetUSerById(int id);
        public void UpdateUser(IUser user);
        public Equipment GetBaseEquipment();
    }
}
