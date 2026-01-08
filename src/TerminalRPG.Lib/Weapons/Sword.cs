namespace TerminalRPG.Lib.Weapons
{
    public class Sword : Weapon
    {
        public required float Sharpness { get; set; }

        public Sword() : base("Sword", 100, Enums.DamageType.Normal) { }

    }
}
