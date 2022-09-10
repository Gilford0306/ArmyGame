using ArmyGame.Menu;

Console.WriteLine("\tArmy game!");
Player player_1 = new Player();
Console.WriteLine("Create army player 1");
Console.WriteLine("Press enter to continue");
string e = Console.ReadLine();
Console.Clear();
Console.WriteLine("Your 1 fighter\n");
player_1.Create();
Console.Clear();
//Console.WriteLine("Your 2 fighter\n");
//player_1.Create();
//Console.Clear();
//Console.WriteLine("Your 3 fighter\n");
//player_1.Create();
//Console.Clear();
var player_2 = new Player();
Console.WriteLine("Create army player 2");
Console.WriteLine("Press enter to continue");
e = Console.ReadLine();
Console.Clear();
Console.WriteLine("Your 1 fighter\n");
player_2.Create();
Console.Clear();
//Console.WriteLine("Your 2 fighter\n");
//player_2.Create();
//Console.Clear();
//Console.WriteLine("Your 3 fighter\n");
//player_2.Create();
//Console.Clear();

Console.WriteLine("Let`s fight");
Console.WriteLine("Press enter to continue");
e = Console.ReadLine();


do
{
    Console.Clear();
    if (player_1.list.Count == 0 || (player_2.list.Count == 0))
    {
        break;
    }
    Console.WriteLine("Player 1 - choose fighter ");
    var first = player_1.Choose();
    Console.WriteLine("Player 2 - choose fighter ");
    var second = player_2.Choose();
    if (first.Initiative > second.Initiative)
    {
        Console.WriteLine("Player 1 attack first");
        second.GetDamage(first);
        if (second.HP < 1)
        {
            player_2.list.Remove(second);
            continue;
        }
        first.GetDamage(second);
        if (first.HP < 1)
        {
            player_1.list.Remove(first);
            continue;
        }
    }
    else if (first.Initiative < second.Initiative)
    {
        Console.WriteLine("Player 2 attack first");
        first.GetDamage(second);
        if (first.HP < 1)
        {
            player_1.list.Remove(first);
            continue;
        }
        second.GetDamage(first);
        if (second.HP < 1)
        {
            player_2.list.Remove(second);
            continue;
        }
    }
    else
    {
        Console.WriteLine("Players attack simultaneously");
        second.GetDamage(first);
        first.GetDamage(second);
        if (second.HP < 1)
        {
            player_2.list.Remove(second);
        }
        if (first.HP < 1)
        {
            player_1.list.Remove(first);
        }
    }
    Console.WriteLine("Press enter to next round");
    e = Console.ReadLine();
} while (true);
if (player_1.list.Count == 0&&player_2.list.Count == 0)
{
    Console.WriteLine("Draw");
}
else if (player_1.list.Count == 0)
    Console.WriteLine("Player 2 Win");
else 
    Console.WriteLine("Player 1 Win");



