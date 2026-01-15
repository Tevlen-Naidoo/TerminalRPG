using TerminalRPG.Lib.Enums;

namespace TerminalRPG.Lib.Weapons
{

    public class SwordFactory : IWeaponFactory<Sword>
    {

        public Sword CreateFire()
        {
            return new SwordBuilder()
                    .setSharpness(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Fire)
            .setName(Strings.Weapons.FireSword)
                    .build();
        }

        public Sword CreateWater()
        {
            return new SwordBuilder()
                    .setSharpness(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Water)
            .setName(Strings.Weapons.WaterSword)
                    .build();
        }

        public Sword CreateEarth()
        {
            return new SwordBuilder()
                    .setSharpness(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Earth)
            .setName(Strings.Weapons.EarthSword)
                    .build();
        }

        public Sword CreateAir()
        {
            return new SwordBuilder()
                    .setSharpness(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Air)
            .setName(Strings.Weapons.AirSword)
                    .build();
        }

        public Sword CreateNormal()
        {
            return new SwordBuilder()
                    .setSharpness(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Normal)
            .setName(Strings.Weapons.NormalSword)
                    .build();
        }

    }

}
