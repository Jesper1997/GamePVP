using System;
using DAL;

namespace DalFactoty
{
    public class UserDALFactory
    {
        public IDal.Interface.IUserDAL GetDalUser() => new DAL.UserDAL();
    }
}
