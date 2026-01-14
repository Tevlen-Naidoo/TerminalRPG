using TerminalRPG.Lib.Weapons;
using TerminalRPG.Lib.Enums;

namespace TerminalRPG.Lib.Characters
{

    public abstract class Character
    {
        public required string Name { get; init; }
        public required int MaxHealth { get; init; }
        public required int CurrentHealth { get; set; }

        public required List<Weapon> Weapons { get; init; }
        public Weapon Equipped { get; set; }

        public required List<DamageType> Weaknesses { get; set; }
        public required List<DamageType> Strengths { get; set; }

        protected Character(string name, int maxHealth)
        {
            Name = name;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;

            Weapons = new List<Weapon>();

            Equipped = new Unarmed();
        }

        public void setHealth(int newHealth)
        {
            if (newHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
            else
            {
                CurrentHealth = newHealth;
            }
        }

        public void addWeapon(Weapon weapon)
        {
            Weapons.Add(weapon);
        }

        public void removeWeapon(Weapon weapon)
        {
            Weapons.Remove(weapon);
        }

        public void removeWeapon(int index)
        {
            Weapons.RemoveAt(index);
        }

        public void equipWeapon(Weapon weapon)
        {
            Equipped = weapon;
        }

        public void equipWeapon(int index)
        {
            Equipped = Weapons[index];
        }

        public void setWeaknesses(List<DamageType> weaknesses)
        {
            Weaknesses = weaknesses;
        }

        public bool isDead()
        {
            return CurrentHealth <= 0;
        }

        public void takeDamage(Weapon weapon)
        {
            float multiplier = 1.0f;

            int baseDamage = weapon.getDamage();

            DamageType damageType = weapon.Damage;

            if (Weaknesses.Contains(damageType))
            {
                multiplier = 1.5f;
            }
            else if (Strengths.Contains(damageType))
            {
                multiplier = 0.5f;
            }

            int totaldamage = Convert.ToInt16(Math.Ceiling(baseDamage * multiplier));

            setHealth(CurrentHealth - totaldamage);
        }

        public void attack(ref Character enemy)
        {
            enemy.takeDamage(Equipped);
        }

    }
}
