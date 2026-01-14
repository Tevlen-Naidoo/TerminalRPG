using TerminalRPG.Lib.Exceptions;

namespace TerminalRPG.Lib.Weapons
{
    public class StaffBuilder : WeaponBuilder<StaffBuilder>
    {
        public float Affinity { get; set; }

        public StaffBuilder setAffinity(float affinity)
        {
            Affinity = affinity;
            return this;
        }

        public override Staff build()
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new InvalidWeaponNameException();
            }

            return new Staff(Affinity)
            {
                Name = this.Name,
                BaseDamage = this.BaseDamage,
                Damage = this.Damage
            };
        }

    }
}
