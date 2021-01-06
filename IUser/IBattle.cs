using System.Collections.Generic;

namespace IModel
{
    public interface IBattle
    {
        List<Icharacter> IFighters { get; }
        int PlayerSkillPoints { get; set; }
        int playersturn { get; set; }
    }
}
