using TerminalRPG.Lib.Exceptions;

namespace TerminalRPG.Lib.Weapons
{
    public class SwordBuilder : WeaponBuilder<SwordBuilder>
    {
        public float Sharpness { get; set; }

        public SwordBuilder setSharpness(float sharpness)
        {
            Sharpness = sharpness;
            return this;
        }

        public override Sword build()
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new InvalidWeaponNameException();
            }

            return new Sword(Sharpness)
            {
                Name = this.Name,
                BaseDamage = this.BaseDamage,
                Damage = this.Damage
            };
        }

    }
}
