using TerminalRPG.Lib.Exceptions;

namespace TerminalRPG.Lib.Weapons
{
    public class BowBuilder : WeaponBuilder<BowBuilder>
    {
        public float Power { get; set; }

        public BowBuilder setPower(float power)
        {
            Power = power;
            return this;
        }

        public override Bow build()
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new InvalidWeaponNameException();
            }

            return new Bow(Power)
            {
                Name = this.Name,
                BaseDamage = this.BaseDamage,
                Damage = this.Damage
            };
        }

    }
}
