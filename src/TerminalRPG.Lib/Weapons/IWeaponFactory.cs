namespace TerminalRPG.Lib.Weapons
{
    public interface IWeaponFactory<T>
    {
        T CreateFire();
        T CreateWater();
        T CreateEarth();
        T CreateAir();
        T CreateNormal();
    }
}
