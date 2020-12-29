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
        public string Pw { get; set; }

        public  List<Character> Characters { get; set; }
        [JsonIgnore]
        List<@int> IUser.characters => converCharacters();

        public User()
        {
            Characters = new List<Character>();
        }

        private List<@int> converCharacters()
        {
            List<@int> characters = new List<@int>();
            foreach(var character in Characters)
            {
                characters.Add(character);
            }
            return characters;
        }
    }
}
