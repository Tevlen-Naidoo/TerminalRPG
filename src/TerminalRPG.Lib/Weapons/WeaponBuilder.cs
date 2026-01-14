using TerminalRPG.Lib.Enums;

namespace TerminalRPG.Lib.Weapons
{
    public abstract class WeaponBuilder
    {

        public required string Name { get; set; }
        public required int BaseDamage { get; set; }
        public required DamageType Damage { get; set; }

        public WeaponBuilder setName(string name)
        {
            Name = name;
            return this;
        }

        public WeaponBuilder setBaseDamage(int baseDamage)
        {
            BaseDamage = baseDamage;
            return this;
        }

        public WeaponBuilder setDamageType(DamageType damage)
        {
            Damage = damage;
            return this;
        }

        public abstract Weapon build();

    }
}
