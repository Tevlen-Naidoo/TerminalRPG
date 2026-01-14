using TerminalRPG.Lib.Enums;

namespace TerminalRPG.Lib.Weapons
{
    public abstract class WeaponBuilder<T> where T : WeaponBuilder<T>
    {

        public string? Name { get; set; }
        public int BaseDamage { get; set; }
        public DamageType Damage { get; set; }

        public T setName(string name)
        {
            Name = name;
            return (T)this;
        }

        public T setBaseDamage(int baseDamage)
        {
            BaseDamage = baseDamage;
            return (T)this;
        }

        public T setDamageType(DamageType damage)
        {
            Damage = damage;
            return (T)this;
        }

        public abstract Weapon build();

    }
}
