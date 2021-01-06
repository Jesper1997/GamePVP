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
        public List<Icharacter> IFighters { get => ConverCharacters(); }
        public List<Character> Fighters { get; set; }
        public int PlayerSkillPoints { get; set; }
        public int playersturn { get; set; }

        public Battle()
        {
            Fighters = new List<Character>();
        }

        private List<Icharacter> ConverCharacters()
        {
            List<Icharacter> characters = new List<Icharacter>();
            foreach (Character chara in Fighters)
            {
                characters.Add(chara);
            }
            return characters;
        }

    }
}
