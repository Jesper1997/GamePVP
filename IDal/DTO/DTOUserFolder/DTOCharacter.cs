using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IDal.DTO.DTOUserFolder
{
    public class DTOCharacter
    {
        [Key]
        public int Id { get; set; }
        public DTOUser DTOUser { get; set; }
        public int MaxHP { get; set; }
        public int HP { get; set; }
        public int AttackTotalValue { get; set; }
        public int BaseAttack { get; set; }
        public int DefenceTotalValue { get; set; }
        public int BaseDefence { get; set; }
        public int SpecialAttackTotlaValue { get; set; }
        public int BaseSpecialAttack { get; set; }
        public int AgilityTotalValue { get; set; }
        public int BaseAgility { get; set; }
    }
}
