using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Hero
    {
        //General stats--------------------------------------
        private string name;
        private int health;
        private int healthCap;
        private AbilityConsumtion abilityConsumtion;
        private int quantityAbilityConsumption;
        private int quantityAbilityConsumptionCap;
        private int level;
        private int levelCap;
        //Attack stats---------------------------------------
        private int damage;
        private int armorPenetration;
        private int armorPenetrationCap;
        private int magicPenetration;
        private int magicPenetrationCap;
        private float attackSpeed;
        private float attackSpeedCap;
        //Defence stats--------------------------------------
        private int armor;
        private int magicResist;
        //Regenerating stats---------------------------------
        private int lifeSteal;
        private int lifeStealCap;
        private int healthRegen;
        private int abilityConsumtionRegen;
        private int abilityConsumptionRegenCap;
        //Abilities------------------------------------------
        private Ability passiveAbility;
        private Ability firstAbility;
        private Ability secondAbility;
        private Ability thirdAbility;
        private Ability ultimateAbility;
        //Inventory------------------------------------------
        private Item[] inventory = new Item[6];

        public int ArmorGetSet
        {
            get
            {
                return this.armor;
            }
            set
            {
                this.armor = value;
            }
        }

        public Ability FirstAbilityGet
        {
            get
            {
                return this.firstAbility;
            }
        }
        public Ability SecondAbilityGet
        {
            get
            {
                return this.secondAbility;
            }
        }
        public Ability ThirdAbilityGet
        {
            get
            {
                return this.thirdAbility;
            }
        }
        public Ability UltimateAbility
        {
            get
            {
                return this.ultimateAbility;
            }
        }


       

        public Hero(
            string newName,
            int newHealth,
            AbilityConsumtion newAbilityConsumption,
            int newQuantityAbilityConsumption,
            int newDamage,
            int newArmorPenetration,
            int newMagicPenetration,
            float newAttackSpeed,
            int newArmor,
            int newMagicResist,
            int newLifeSteal,
            int newHealthRegen,
            int newAbilityConsumptionRegen,
            Ability newPassiveAbility,
            Ability newFirstAbility,
            Ability newSecondAbility,
            Ability newThirdAbility,
            Ability newUltimateAbility,
            int newArmorPenetrationCap = 100,
            int newMagicPenetrationCap = 100,
            float newAttackSpeedCap = 2.5f,
            int newLifeStealCap = 100,
            int newAbilityConsumptionRegenCap = 80,
            int newLevel = 1,
            int newLevelCap = 18

            )
        {
            this.name = newName;
            this.health = newHealth;
            this.healthCap = newHealth;
            this.abilityConsumtion = newAbilityConsumption;
            this.quantityAbilityConsumption = newQuantityAbilityConsumption;
            this.quantityAbilityConsumptionCap = newQuantityAbilityConsumption;
            this.damage = newDamage;
            this.armorPenetration = newArmorPenetration;
            this.magicPenetration = newMagicPenetration;
            this.attackSpeed = newAttackSpeed;
            this.armor = newArmor;
            this.magicResist = newMagicResist;
            this.lifeSteal = newLifeSteal;
            this.healthRegen = newHealthRegen;
            this.abilityConsumtionRegen = newAbilityConsumptionRegen;
            this.passiveAbility = newPassiveAbility;
            this.firstAbility = newFirstAbility;
            this.secondAbility = newSecondAbility;
            this.thirdAbility = newThirdAbility;
            this.ultimateAbility = newUltimateAbility;
            //Caps--------Const-----------------------------
            this.armorPenetrationCap = newArmorPenetrationCap;
            this.magicPenetrationCap = newMagicPenetrationCap;
            this.attackSpeedCap = newAttackSpeedCap;
            this.lifeStealCap = newLifeStealCap;
            this.abilityConsumptionRegenCap = newAbilityConsumptionRegenCap;
            this.level = newLevel;
            this.levelCap = newLevelCap;
        }

        public void basicAttack(Hero attacker, Hero attacked)
        {
            attacked.health -= attacker.damage - ((80 / 100)*(attacked.armor - attacker.armorPenetration));
            attacker.health += attacker.lifeSteal * (80 / 100);
        }

        public void castAbility(Hero attacker, Hero attacked, Ability ability)
        {
            if (attacker.quantityAbilityConsumption - ability.ConsumptionValueGet > 0)
            {
                if (ability.ULtimateGet == false)
                {
                    if (ability.KindOfAbilityGet.Equals(Ability.KindOfAbility.Damage))
                    {
                        attacked.health -= ability.ValueGet - ((80 / 100) * (attacked.magicResist - attacker.magicPenetration));
                    }
                }
                else if (ability.ULtimateGet == true && attacker.level >= 6)
                {
                    if (ability.KindOfAbilityGet.Equals(Ability.KindOfAbility.Damage))
                    {
                        attacked.health -= ability.ValueGet - ((80 / 100) * (attacked.magicResist - attacker.magicPenetration));
                    }
                }
                else
                {
                    Console.WriteLine("You need level 6 to use that ability!");
                }
            }
            else
            {
                Console.WriteLine("Not enought {0}", attacker.abilityConsumtion.KindAbilityConsumptionGet);
            }
        }


        
    }
}
