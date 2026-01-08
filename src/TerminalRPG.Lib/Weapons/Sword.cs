namespace TerminalRPG.Lib.Weapons
{
    public class Sword : Weapon
    {
        public float Sharpness { get; set; }

        public Sword(float sharpness) : base("Sword", 100, Enums.DamageType.Normal)
        {
            Sharpness = sharpness;
        }

    }
}
