namespace TerminalRPG.Lib.Weapons
{
    public class Staff : Weapon
    {
        public float Affinity { get; set; }

        public Staff(float affinity) : base("Staff", 100, Enums.DamageType.Normal)
        {
            Affinity = affinity;
        }

        public override int getDamage()
        {
            return Convert.ToInt16(Math.Ceiling(Affinity * BaseDamage));
        }
    }
}
