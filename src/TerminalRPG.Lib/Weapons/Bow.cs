namespace TerminalRPG.Lib.Weapons
{
    sealed public class Bow : Weapon
    {
        public float Power { get; set; }

        public Bow(float power) : base("Bow", 100, Enums.DamageType.Normal)
        {
            Power = power;
        }

        public override int getDamage()
        {
            return Convert.ToInt16(Math.Ceiling(Power * BaseDamage));
        }

    }
}
