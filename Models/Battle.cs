using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using IModel;

namespace Model
{
    public class Battle : IBattle
    {
        [Key]
        public int id { get; set; }
        [JsonIgnore]
        public List<@int> IFighters { get => ConverCharacters(); }
        public List<Character> Fighters { get; set; }
        public int PlayerSkillPoints { get; set; }
        public int playersturn { get; set; }

        public Battle()
        {
            Fighters = new List<Character>();
        }

        private List<@int> ConverCharacters()
        {
            List<@int> characters = new List<@int>();
            foreach (Character chara in Fighters)
            {
                characters.Add(chara);
            }
            return characters;
        }

    }
}
