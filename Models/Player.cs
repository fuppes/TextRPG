using OOP_Vererbung.Abstract;
using OOP_Vererbung.AbstractClasses;
using OOP_Vererbung.Attack;

namespace OOP_Vererbung.Models
{
  internal class Player : Human
  {
    public string? Name { get; private set; }
    public int Health { get; set; }
    public Debuff Debuff { get; private set; }

    public Player(string? name)
    {
      this.Name = name;
      this.Health = 50 * Mage.HealthModificator;
      Debuff = new ( 0, 0, 0 );
    }

    public void CalculateDamage(Damage damage)
    {
      Health -= damage.DirectDamage;
      if(damage.Debuff == null) { damage.Debuff = new(0, 0, 0); }
      this.Debuff.Stack = Debuff.Stack + damage.Debuff.Stack;
      Health -= (Debuff.Stack + damage.Debuff.Stack) * Debuff.DamagePerStack;
    }
  }
}
