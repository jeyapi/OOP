using System; 

namespace InheritanceMinigame.Classes
{
    public class Dragon : Character
    {
        public Dragon(string name) : base(name, 200, 20)
        {
            BattleCry = "ROAAAR!";
        }

        public override void PerformAttack(Character target)
        {
            Console.WriteLine($"{Name} roars '{BattleCry}' and breathes devastating fire across the battlefield!");            target.TakeDamage(AttackPower);
        }
    }
}