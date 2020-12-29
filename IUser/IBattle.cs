using System.Collections.Generic;

namespace IModel
{
    public interface IBattle
    {
        List<@int> IFighters { get; }
        int PlayerSkillPoints { get; set; }
        int playersturn { get; set; }
    }
}
