using OOP_Vererbung.Abstract;
using OOP_Vererbung.AbstractClasses;

namespace OOP_Vererbung.Models
{
  internal class Enemy : Orc
  {
    /// <summary>
    /// The enemies name
    /// </summary>
    public string? Name { get; private set; }
    public int Health { get; private set; }

    public Enemy(string? name)
    {
      this.Name = name;
      this.Health = 50 * Warrior.HealthModificator;
    }
  }
}
