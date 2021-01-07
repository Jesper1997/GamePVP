using System.Collections.Generic;

namespace IModel
{
    public interface IBattle
    {
        int id { get;}
        List<Icharacter> IFighters { get; }
        int PlayerSkillPoints { get; set; }
        int playersturn { get; set; }

        public void InsertFighter(Icharacter icharacter);
    }
}
