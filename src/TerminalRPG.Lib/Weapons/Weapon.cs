using TerminalRPG.Lib.Enums;

namespace TerminalRPG.Lib.Weapons
{
    public abstract class Weapon
    {
        public string Name { get; }
        public int BaseDamage { get; }
        public DamageType Damage { get; }

        protected Weapon(string name, int baseDamage, DamageType damage)
        {
            Name = name;
            BaseDamage = baseDamage;
            Damage = damage;
        }
    }
}

