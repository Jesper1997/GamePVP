using System;

namespace IDal.Interface
{
    public interface IUserDAL
    {
        public void InsertUser(DTO.DTOUserFolder.DTOUser user);

        public IDal.DTO.DTOUserFolder.DTOUser GetUser(string name, string PW);

        public void InserCharacter(DTO.DTOUserFolder.DTOCharacter character);
    }
}
