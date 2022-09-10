using ArmyGame.Weapone;
using ArmyGame.Weapone.OneHande;
using ArmyGame.Weapone.TwoHande;

namespace ArmyGame.Soldiers
{
    abstract class SolderBase
    {
        private int v1;
        private int v2;
        private OneHandeBlade oneHandeBlade;
        private Katana katana;

        public string Name { get; }
        public int HP { get; set; }
        public int DamageLevel { get; set; }

        public bool Horse { get; set; }

        public string Class { get; set; }

        public WeaponeBase Weapone { get; set; }



        private SolderBase()
        {}

        protected SolderBase(string name, int hp, int damage,  WeaponeBase weapone)
        {
            DamageLevel = damage;
            HP = hp;
            Weapone = weapone;
            Name = name;
            Horse = false;
        }

        protected SolderBase(string name, int v1, int v2, OneHandeBlade oneHandeBlade)
        {
            Name = name;
            this.v1 = v1;
            this.v2 = v2;
            this.oneHandeBlade = oneHandeBlade;
        }

        protected SolderBase(string name, int v1, int v2, Katana katana)
        {
            Name = name;
            this.v1 = v1;
            this.v2 = v2;
            this.katana = katana;
        }

        public virtual void GetDamage(SolderBase solder)
        {
            string res1 = $"{solder.Name} send damage to {Name}!";
            if (solder.Horse == true)
            {
                res1 += $"{solder.Name} send damage second time to {Name}!";
            }
            Console.WriteLine(res1);
            string res2 = $"{solder.Name} hp is {solder.HP} / {Name} hp is {HP}!";
            Console.WriteLine(res2);
        }
        public virtual void Dead()
        {
            Console.WriteLine($"{Name} dead");
        }
    }
}
