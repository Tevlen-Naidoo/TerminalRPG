using TerminalRPG.Lib.Weapons;
using TerminalRPG.Lib.Enums;

Sword sword = new Sword(100);

System.Console.WriteLine("Damage Type: " + sword.Damage.ToString());

Sword ex = new SwordBuilder().setSharpness(1.0f).setName("Excalibur").setDamageType(DamageType.Fire).setBaseDamage(100).build();
System.Console.WriteLine("Damage Type: " + ex.Damage.ToString());

