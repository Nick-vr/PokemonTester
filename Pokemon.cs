using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTester
{
    internal class Pokemon
    {
        /*Auto props*/

        public string Name { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }

        /*ReadOnly props*/

        public double Average
        {
            get { return (HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base) / 6.0; }
        }

        public int Total
        {
            get { return HP_Base + Attack_Base + Defense_Base + SpecialAttack_Base + SpecialDefense_Base + Speed_Base; }
        }

        public int HP_Full
        {
            get { return (((HP_Base + 50) * Level) / 50) + 10; }
        }

        public int Attack_Full
        {
            get { return ((Attack_Base * Level) / 50) + 5; }
        }

        public int Defense_Full
        {
            get { return ((Defense_Base * Level) / 50) + 5; }
        }

        public int SpecialAttack_Full
        {
            get { return ((SpecialAttack_Base * Level) / 50) + 5; }
        }

        public int SpecialDefense_Full
        {
            get { return ((SpecialDefense_Base * Level) / 50) + 5; }
        }

        public int Speed_Full
        {
            get { return ((Speed_Base * Level) / 50) + 5; }
        }

        /*Full props*/

        //HP_Base
        private int hp_Base;

        public int HP_Base
        {
            get { return hp_Base; }
            set { hp_Base = value; }
        }

        //Attack_Base
        private int attack_Base;

        public int Attack_Base
        {
            get { return attack_Base; }
            set { attack_Base = value; }
        }

        //Defense_Base
        private int defense_Base;

        public int Defense_Base
        {
            get { return defense_Base; }
            set { defense_Base = value; }
        }

        //SpecialAttack_Base
        private int specialAttack_Base;

        public int SpecialAttack_Base
        {
            get { return specialAttack_Base; }
            set { specialAttack_Base = value; }
        }

        //SpecialDefense_Base
        private int specialDefense_Base;

        public int SpecialDefense_Base
        {
            get { return specialDefense_Base; }
            set { specialDefense_Base = value; }
        }

        //Speed_Base
        private int speed_Base;

        public int Speed_Base
        {
            get { return speed_Base; }
            set { speed_Base = value; }
        }

        //Level
        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        /*Constructor*/

        public Pokemon(
                        string name,
                        int startLevel,
                        int hp_Base,
                        int attack_Base,
                        int defense_Base,
                        int specialAttack_Base,
                        int specialDefense_Base,
                        int speed_Base)
        {
            Name = name;
            Level = startLevel;
            HP_Base = hp_Base;
            Attack_Base = attack_Base;
            Defense_Base = defense_Base;
            SpecialAttack_Base = specialAttack_Base;
            SpecialDefense_Base = specialDefense_Base;
            Speed_Base = speed_Base;
        }

        public Pokemon()
        {
        }

        /*Methods*/

        public void LevelUp(int maxLevel)
        {
            for (int i = 1; i <= maxLevel; i++)
            {
                level++;
            }
        }

        public string Showinfo()
        {
            return
                $"{Name} (level {Level})\n" +
                $"Base stats:\n" +
                $"\t*Health: {HP_Base}\n" +
                $"\t*Attack: {Attack_Base}\n" +
                $"\t*Defense: {Defense_Base}\n" +
                $"\t*Sp.Attack: {SpecialAttack_Base}\n" +
                $"\t*Sp.Defense: {SpecialDefense_Base}\n" +
                $"\t*Speed: {Speed_Base}\n\n" +
                $"Full stats:\n" +
                $"\t*Health: {HP_Full}\n" +
                $"\t*Attack: {Attack_Full}\n" +
                $"\t*Defense: {Defense_Full}\n" +
                $"\t*Sp.Attack: {SpecialAttack_Full}\n" +
                $"\t*Sp.Defense: {SpecialDefense_Full}\n" +
                $"\t*Speed: {Speed_Full}\n";
        }
    }
}