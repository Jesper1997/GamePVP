using Microsoft.EntityFrameworkCore;
using IDal;
using System;
using System.Collections.Generic;
using System.Text;
using IModel;
using Model;
using Model.Items;

namespace Dal
{
    public class DalUser : DbContext, IDalUser
    {
        private protected DBCreate DB { get; set; }

        public List<IUser> GetUsers()
        {
            using (var context = new DBCreate())
            {
                var users = context.user;
                List<IUser> Users = new List<IUser>(); ;
                foreach(var user in users)
                {
                    Users.Add(user);
                }
                return Users;
            }
        }

        public void InsertUser(IUser user)
        {
            using (var context = new DBCreate())
            {
                //try
                //{
                    DB = new DBCreate();
                    DB.EnsureDbIsCreated();
                    context.user.Add((User)user);
                    context.SaveChanges();
                //}
                //catch
                //{
                //    //TODO Implement Exceptioin 
                //    new NotImplementedException();
                //}
            }
        }

        public void UpdateUser(IUser user)
        {
            using (var context = new DBCreate())
            {
                DB = new DBCreate();
                DB.EnsureDbIsCreated();
                context.user.Update((User)user);
                context.SaveChanges();
            }
        }

        public IUser LoginUser(string name, string pw)
        {
            try
            {
                using (var context = new DBCreate())
                {
                    var users = context.user;
                    foreach(var user in users)
                    {
                        if (user.name != name || user.Pw != pw)
                        {
                            continue;
                        }
                        return user;
                    }
                    return null;
                }
                
            }
            catch
            {
                return null;
            }
        }

        public User GetUSerById(int id)
        {
            using(var contex = new DBCreate())
            {
                User user = contex.user.Find(id);
                return user;
            }
        }

        public Equipment GetBaseEquipment()
        {
            using (var context = new DBCreate())
            {
                Equipment equip = context.equipment.Find(1);
                return equip;
            }
        }
    }
}
