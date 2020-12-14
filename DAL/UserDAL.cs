using System;
using IDal.Interface;
using Microsoft.EntityFrameworkCore;
using IDal;

namespace DAL
{
    //TODO Onderzoeken hoe automatisch aan maken van de tabel en relaties
    public class UserDAL: DbContext, IUserDAL 
    {
        private protected DBCreate DB { get; set; }
        //private protected DbSet<IDal.DTO.DTOUserFolder.DTOUser> user { get; set;}
        //private protected DbSet<IDal.DTO.DTOUserFolder.DTOCharacter> Characters { get; set; }

        public void InsertUser(IDal.DTO.DTOUserFolder.DTOUser DTOuser)
        {
            using( var context = new DBCreate())
            {
                try
                {
                    DB = new DBCreate();
                    DB.EnsureDbIsCreated();
                    context.user.Add(DTOuser);
                    context.SaveChanges();
                }
                catch
                {
                    //TODO Implement Exceptioin
                    new NotImplementedException();
                }
            }
        }

        public IDal.DTO.DTOUserFolder.DTOUser GetUser(string name, string PW)
        {
            IDal.DTO.DTOUserFolder.DTOUser datauser;
            using (var context = new DBCreate())
            {
                datauser = context.user.Find(name);
            }
            return datauser.PW == PW ? datauser : null;
        }

        public void InserCharacter(IDal.DTO.DTOUserFolder.DTOCharacter character)
        {
            DB = new DBCreate();
            DB.EnsureDbIsCreated();
            using (var context = new DBCreate())
            {
                context.EnsureDbIsCreated();
                context.Characters.Add(character);
                context.SaveChanges();
            }
        }
    }
}
