using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class AbilityConsumtion
    {
        private KindAbilityConsumption kindAbilityConsumption;

        public KindAbilityConsumption KindAbilityConsumptionGet
        {
            get
            {
                return this.kindAbilityConsumption;
            }
        }
        public enum KindAbilityConsumption
        {
            Mana,
            Energy,
            None,
        }

        public AbilityConsumtion(
           KindAbilityConsumption newKindAbilityConsumption)
        {
            this.kindAbilityConsumption = newKindAbilityConsumption;
        }
    }
}
