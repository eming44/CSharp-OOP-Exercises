using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero garen = new Hero(
                "Garen",
                616,
                new AbilityConsumtion(AbilityConsumtion.KindAbilityConsumption.None),
                1,
                66,
                0,
                0,
                0.63f,
                36,
                32,
                0,
                8,
                0,
                new Ability("Perseverance", 1, 0, Ability.KindOfAbility.Passive),
                new Ability("Decisive Strike", 80, 0, Ability.KindOfAbility.Damage),
                new Ability("Courage", (32 * (60 / 100)), 0, Ability.KindOfAbility.StatsUp),
                new Ability("Judgment", 40, 0, Ability.KindOfAbility.Damage),
                new Ability("Demacian Justice", 100, 0, Ability.KindOfAbility.Damage, true));


            Hero garen2 = new Hero(
                "Garen",
                616,
                new AbilityConsumtion(AbilityConsumtion.KindAbilityConsumption.None),
                1,
                66,
                0,
                0,
                0.63f,
                36,
                32,
                0,
                8,
                0,
                new Ability("Perseverance", 1, 0, Ability.KindOfAbility.Passive),
                new Ability("Decisive Strike", 30, 0, Ability.KindOfAbility.Damage),
                new Ability("Courage", (32 * (60 / 100)), 0, Ability.KindOfAbility.StatsUp),
                new Ability("Judgment", 14, 0, Ability.KindOfAbility.Damage),
                new Ability("Demacian Justice", 175, 0, Ability.KindOfAbility.Damage, true));

            garen.basicAttack(garen, garen2);
            garen.castAbility(garen, garen2, garen.FirstAbilityGet);
            garen.castAbility(garen, garen2, garen.ThirdAbilityGet);



        }
    }
}
