using TerminalRPG.Lib.Enums;

namespace TerminalRPG.Lib.Weapons
{
    public abstract class Weapon
    {
        public string Name { get; init; }
        public int BaseDamage { get; init; }
        public DamageType Damage { get; init; }

        protected Weapon(string name, int baseDamage, DamageType damage)
        {
            Name = name;
            BaseDamage = baseDamage;
            Damage = damage;
        }

        public abstract int getDamage();
    }
}

