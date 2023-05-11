namespace VirtualTableTop.Shared
{
    public class Spellcasting : IComponent
    {
        public string SpellcastingClass { get; set; }
        public int SpellcastingAbility { get; set; }
        public Dictionary<int, int> SpellsPerSpellLevel { get; set; }
        public List<Spell> KnownSpells { get; set; }
    }

}