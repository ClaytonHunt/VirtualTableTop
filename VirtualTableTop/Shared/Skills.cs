namespace VirtualTableTop.Shared
{
    public class Skills : IComponent
    {
        public List<Skill> SkillList { get; set; } = new List<Skill>();
        // Initialize SkillList with the skills your game supports...
    }
}