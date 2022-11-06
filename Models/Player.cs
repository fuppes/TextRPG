using OOP_Vererbung.Abstract;
using OOP_Vererbung.AbstractClasses;

namespace OOP_Vererbung.Models
{
  internal class Player : Human
  {
    public string? Name { get; private set; }
    public int Health { get; set; }

    public Player(string? name)
    {
      this.Name = name;
      this.Health = 50 * Mage.HealthModificator;
    }
  }
}
