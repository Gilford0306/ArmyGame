
namespace ArmyGame.Weapone.Bow
{
    abstract class BowBase: WeaponeBase
    {
        public BowBase(int i, int j) : base(i, j)
        { }

        public override int SendDamage() { return Damage ; }
    }
}
