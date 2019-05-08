using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Item
    {
        //attack---------------------------------------------
        private int damage;
        private int armorPenetration;
        private int magicPenetration;
        private float attackSpeed;
        //Defence--------------------------------------------
        private int armor;
        private int magicResist;
        //Regenerating---------------------------------------
        private int lifesteal;
        private int healthRegen;
        private int abilityConsumtionRegen;

        public Item (
            int newDamage,
            int newArmorPenetration,
            int newMagicPenetration,
            int newAttackSpeed,
            int newArmor,
            int newMagicResist,
            int newLifeSteal,
            int newHealthRegen,
            int newAbilityConsumptionRegen)
        {
            this.damage = newDamage;
            this.armorPenetration = newArmorPenetration;
            this.magicPenetration = newMagicPenetration;
            this.attackSpeed = newAttackSpeed;
            this.armor = newArmor;
            this.magicResist = newMagicResist;
            this.lifesteal = newLifeSteal;
            this.healthRegen = newHealthRegen;
            this.abilityConsumtionRegen = newAbilityConsumptionRegen;
        }
    }
}
