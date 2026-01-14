namespace TerminalRPG.Lib.Weapons
{
    public class Unarmed : Weapon
    {
        public Unarmed() : base("Unarmed", 10, Enums.DamageType.Normal) { }

        public override int getDamage()
        {
            return BaseDamage;
        }
    }
}
