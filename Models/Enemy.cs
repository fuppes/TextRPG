using OOP_Vererbung.Abstract;
using OOP_Vererbung.AbstractClasses;
using OOP_Vererbung.Attack;

namespace OOP_Vererbung.Models
{
  internal class Enemy : Orc
  {
    /// <summary>
    /// The enemies name
    /// </summary>
    public string? Name { get; private set; }
    public int Health { get; private set; }
    public Debuff Debuff { get; private set; }

    public Enemy(string? name)
    {
      this.Name = name;
      this.Health = 50 * Warrior.HealthModificator;
      this.Debuff = new Debuff(0, 0, 0);
    }

    public void CalculateDamage(Damage damage)
    {
      Health -= damage.DirectDamage;
      this.Debuff.Stack = Debuff.Stack + damage.Debuff.Stack;
      Health -= (Debuff.Stack + damage.Debuff.Stack) * Debuff.DamagePerStack;
    }
  }
}
