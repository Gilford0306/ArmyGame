using ArmyGame.Weapone.TwoHande;
using ArmyGame.Weapone.OneHande;
using ArmyGame.Weapone.Bow;

namespace ArmyGame.Soldiers

{
    class SoldermanBase : SolderBase
    {
        public int Initiative { get; set; }

        delegate void WarriorDelegate();
        WarriorDelegate warriorDelegate;
        public SoldermanBase(string name, string warrior = "viking") : base(name, 1, 1,  new TwoHandeBlade())
        {
            if (warrior.ToLower().Equals("viking"))
                warriorDelegate += Create_Viking;
            else if (warrior.ToLower().Equals("rome"))
                warriorDelegate += Create_RomeLegionnaire;
            else if (warrior.ToLower().Equals("indian"))
                warriorDelegate += Create_IndianWarrior;
            else if (warrior.ToLower().Equals("sam"))
                warriorDelegate += Create_Samurai;
            else if (warrior.ToLower().Equals("eng"))
                warriorDelegate += Create_EnglishLongbowmen;
            else if (warrior.ToLower().Equals("chi"))
                warriorDelegate += Create_ChinaCrossbowman;
            else if (warrior.ToLower().Equals("hus"))
                warriorDelegate += Create_Mongolian_Horsman;
            else if (warrior.ToLower().Equals("mong"))
                warriorDelegate += Create_Samurai;
        }

        public void Create_Viking()
        {
            HP = 25;
            DamageLevel = 10;
            this.Initiative = 10;
            Class = "Viking";
        }
        public void Create_RomeLegionnaire()
        {
            HP = 15;
            DamageLevel = 5;
            Initiative = 9;
            Weapone = new OneHandeBlade();
            Class = "Rome Legionnaire";
        }
        public void Create_IndianWarrior()
        {
            HP = 17;
            DamageLevel = 7;
            Initiative = 11;
            Weapone = new Tomahawk();
            Class = "Indian Warrior";
        }
        public void Create_Samurai()
        {
            HP = 15;
            DamageLevel = 7;
            Initiative = 8;
            Weapone = new Katana();
            Class = "Samurai";
        }
        public void Create_EnglishLongbowmen()
        {
            HP = 16;
            DamageLevel = 3;
            Initiative = 20;
            Weapone = new English_longbow();
            Class = "English Longbowmen";
        }
        public void Create_ChinaCrossbowman()
        {
            HP = 14;
            DamageLevel = 7;
            Initiative = 19;
            Weapone = new Crossbow();
            Class = "China Crossbowman";
        }
        public void Create_Hussar()
        {
            HP = 14;
            DamageLevel = 7;
            Initiative = 6;
            Horse = true;
            Weapone = new Crossbow();
            Class = "Hussar";
        }
        public void Create_Mongolian_Horsman()
        {
            HP = 13;
            DamageLevel = 6;
            Initiative = 7;
            Horse = true;
            Weapone = new Crossbow();
            Class = "Mongolian Horsman";

        }
        public override void GetDamage(SolderBase solder)
        {
            HP -= solder.Weapone.Damage;
            if (solder.Horse == true)
            {
                HP -= solder.Weapone.Damage;
            }
            base.GetDamage(solder);
            if (HP <= 0) Dead();
        }
        public void Run()
        {
            warriorDelegate?.Invoke();
        }
    }
}

