using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Ability
    {
        private string abilityName;
        private int value;
        private int consumptionValue;
        private KindOfAbility kindOfAbility;
        private bool ultimate;

        public bool ULtimateGet
        {
            get
            {
                return this.ultimate;
            }
        }
        public int ValueGet
        {
            get
            {
                return this.value;
            }
        }

        public int ConsumptionValueGet
        {
            get
            {
                return this.consumptionValue;
            }
        }

        public KindOfAbility KindOfAbilityGet
        {
            get
            {
                return this.kindOfAbility;
            }
        }

        public enum KindOfAbility
        {
            Damage,
            Heal,
            Bleed,
            Root,
            Stun,
            Silience,
            ManaRegen,
            StatsUp,
            Passive
        }

        public Ability(
            string newAbilityName,
            int newValue,
            int newConsumptionValue,
            KindOfAbility newKindOfAbility,
            bool newUltimate = false)
        {
            this.abilityName = newAbilityName;
            this.value = newValue;
            this.consumptionValue = newConsumptionValue;
            this.kindOfAbility = newKindOfAbility;
            this.ultimate = newUltimate;
        }
    }
}
