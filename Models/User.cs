using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using IModel;

namespace Model
{
    public class User : IUser
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        [JsonIgnore]
        public string Pw { get; set; }

        public  List<Character> Characters { get; set; }
        [JsonIgnore]
        List<Icharacter> IUser.characters => converCharacters();

        public User()
        {
            Characters = new List<Character>();
        }

        private List<Icharacter> converCharacters()
        {
            List<Icharacter> characters = new List<Icharacter>();
            foreach(var character in Characters)
            {
                characters.Add(character);
            }
            return characters;
        }
    }
}
