using TerminalRPG.Lib.Enums;

namespace TerminalRPG.Lib.Weapons
{

    public class StaffFactory : IWeaponFactory<Staff>
    {

        public Staff CreateFire()
        {
            return new StaffBuilder()
                    .setAffinity(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Fire)
            .setName(Strings.Weapons.FireStaff)
                    .build();
        }

        public Staff CreateWater()
        {
            return new StaffBuilder()
                    .setAffinity(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Water)
            .setName(Strings.Weapons.WaterStaff)
                    .build();
        }

        public Staff CreateEarth()
        {
            return new StaffBuilder()
                    .setAffinity(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Earth)
            .setName(Strings.Weapons.EarthStaff)
                    .build();
        }

        public Staff CreateAir()
        {
            return new StaffBuilder()
                    .setAffinity(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Air)
            .setName(Strings.Weapons.AirStaff)
                    .build();
        }

        public Staff CreateNormal()
        {
            return new StaffBuilder()
                    .setAffinity(1.0f)
            .setBaseDamage(100)
            .setDamageType(DamageType.Normal)
            .setName(Strings.Weapons.NormalStaff)
                    .build();
        }

    }

}
