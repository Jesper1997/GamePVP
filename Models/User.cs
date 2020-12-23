using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        List<ICharacter> IUser.characters => converCharacters();

        public User()
        {
            Characters = new List<Character>();
        }

        private List<ICharacter> converCharacters()
        {
            List<ICharacter> characters = new List<ICharacter>();
            foreach(var character in Characters)
            {
                characters.Add(character);
            }
            return characters;
        }
    }
}
