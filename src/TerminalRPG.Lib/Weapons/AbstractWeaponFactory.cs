using TerminalRPG.Lib.Enums;

namespace TerminalRPG.Lib.Weapons
{
    public abstract class AbstractWeaponFactory<T> where T : AbstractWeaponFactory<T>
    {
        public abstract Weapon FireWeapon();
        public abstract Weapon WaterWeapon();
        public abstract Weapon AirWeapon();
        public abstract Weapon EarthWeapon();
        public abstract Weapon NormalWeapon();
    }

    public class SwordFactory
    {
        public Sword FireWeapon()
        {
            return new SwordBuilder()
                .setSharpness(100)
                .setName(Strings.Weapons.FireSword)
                .setBaseDamage(100)
                .setDamageType(DamageType.Fire)
                .build();
        }
    }
}
