namespace TerminalRPG.Lib.Weapons
{
    sealed public class Sword : Weapon
    {
        public float Sharpness { get; set; }

        public Sword(float sharpness) : base("Sword", 100, Enums.DamageType.Normal)
        {
            Sharpness = sharpness;
        }

        public override int getDamage() => Convert.ToInt16(Math.Ceiling(Sharpness * BaseDamage));
    }
}
