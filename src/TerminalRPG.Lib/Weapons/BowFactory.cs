using TerminalRPG.Lib.Enums;

namespace TerminalRPG.Lib.Weapons
{

    public class BowFactory : IWeaponFactory<Bow>
    {

        public Bow CreateFire()
        {
            return new BowBuilder()
                    .setPower(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Fire)
            .setName(Strings.Weapons.FireBow)
                    .build();
        }

        public Bow CreateWater()
        {
            return new BowBuilder()
                    .setPower(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Water)
            .setName(Strings.Weapons.WaterBow)
                    .build();
        }

        public Bow CreateEarth()
        {
            return new BowBuilder()
                    .setPower(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Earth)
            .setName(Strings.Weapons.EarthBow)
                    .build();
        }

        public Bow CreateAir()
        {
            return new BowBuilder()
                    .setPower(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Air)
            .setName(Strings.Weapons.AirBow)
                    .build();
        }

        public Bow CreateNormal()
        {
            return new BowBuilder()
                    .setPower(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Normal)
            .setName(Strings.Weapons.NormalBow)
                    .build();
        }

    }

}
