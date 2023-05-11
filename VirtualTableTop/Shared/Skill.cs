namespace VirtualTableTop.Shared
{
    public class Skill
    {
        public string Name { get; set; }
        public string AssociatedAbility { get; set; }
        public int Rank { get; set; }
        public bool IsProficient { get; set; }

        public Skill(string name, string associatedAbility)
        {
            Name = name;
            AssociatedAbility = associatedAbility;
            Rank = 0;  // or whatever default rank you want
            IsProficient = false;  // or determine proficiency based on character's class/background
        }

        public int GetModifiedSkillRank(Modifiers modifiers, int proficiencyBonus)
        {
            if (!modifiers.AbilityModifiers.TryGetValue(AssociatedAbility, out var abilityModifier))
            {
                throw new ArgumentException($"Unknown ability: {AssociatedAbility}", nameof(AssociatedAbility));
            }

            var rank = Rank + abilityModifier;

            if (IsProficient)
            {
                rank += proficiencyBonus;
            }

            return rank;
        }
    }

}