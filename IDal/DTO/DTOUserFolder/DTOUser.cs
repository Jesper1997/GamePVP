using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IDal.DTO.DTOUserFolder
{
    //DTO naam wijzigen naar model
    public class DTOUser
    {
        public List<DTOCharacter> Chachters { get; set; }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PW { get; set; }
        public int Points { get; set; }
    }
}
