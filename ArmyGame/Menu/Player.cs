using ArmyGame.Soldiers;

namespace ArmyGame.Menu
{
    internal class Player
    {
        public string name { get; set; }
        public List<SoldermanBase> list { get; set; }

        public Player()
        {
            name = string.Empty;
            list = new List<SoldermanBase>();
        }
        public void Create()
        {
            SoldermanBase player = new SoldermanBase("Jon");
            Console.WriteLine("Swordmans - base class\n");
            Console.WriteLine("Rome Legionnaire - input 1");
            Console.WriteLine("Samurai - input 2");
            Console.WriteLine("Indian Warrior - input 3");
            Console.WriteLine("Viking - input 4");
            Console.WriteLine("\nArchers - always attack first\n");
            Console.WriteLine("China Crossbowman - input 5");
            Console.WriteLine("English Longbowmen- input 6");
            Console.WriteLine("\nHorseman - can attack twice\n");
            Console.WriteLine("China Hussar - input 7");
            Console.WriteLine("Mongolian Horsman - input 8");
            string key = Console.ReadLine();
            Console.WriteLine("Input solder name");
            string name = Console.ReadLine();
            switch (key)
            {
                case "1":
                    player = new SoldermanBase(name, "rome");
                    player.Run();
                    break;
                case "2":
                    player = new SoldermanBase(name, "sam");
                    player.Run();
                    break;
                case "3":
                    player = new SoldermanBase(name, "indian");
                    player.Run();
                    break;
                case "4":
                    player = new SoldermanBase(name, "viking");
                    player.Run();
                    break;
                case "5":
                    player = new SoldermanBase(name, "chi");
                    player.Run();
                    break;
                case "6":
                    player = new SoldermanBase(name, "eng");
                    player.Run();
                    break;
                case "7":
                    player = new SoldermanBase(name, "hus");
                    player.Run();
                    break;
                case "8":
                    player = new SoldermanBase(name, "mong");
                    player.Run();
                    break;
                default:
                    Console.WriteLine("Only number 1-8");
                    break;

            }
            list.Add(player);
            Console.WriteLine("to continue press enter");
            string e = Console.ReadLine();
        }

        public SoldermanBase Choose()
        {
            for (int i = 0; i < list.Count; i++)
            {

                Console.WriteLine($"{i + 1}.{list[i].Class} - {list[i].Name}");
            }
            Console.WriteLine("Chose fighter ");
            int f;
            int ch; 
            do
            {
                Console.WriteLine("Input number of fighter");
                f = 1;
                ch = int.Parse(Console.ReadLine());
                if (ch - 1 < 0 || ch  > list.Count)
                {
                    f = 0;
                }
            } while (f == 0);

        return list[ch - 1];
        }
    }
}
