using OOP_Vererbung.Attack;
using OOP_Vererbung.Models;

namespace OOP_Vererbung.AbstractClasses
{
  internal abstract class Mage
  {
    public const int HealthModificator = 3;

    /// <summary>
    /// Fireball deals damage to enemies
    /// There is a chance to burn the enemy
    /// </summary>
    public Damage CastFireball()
    {
      Random random = new Random();

      int chanceToHitTarget = random.Next(100) % 2;

      if(chanceToHitTarget == 0)
      {
        int damage = random.Next(10, 30);

        Helperclass.ChangeConsoleColor($@"Dein Feuerball verursacht {damage} Schaden", ConsoleColor.Red);

        int chanceForBurning = random.Next(0, 100);
        chanceForBurning = chanceForBurning % 2;

        if (chanceForBurning == 0)
        {
          Helperclass.ChangeConsoleColor("Dein Gegner brennt!", ConsoleColor.Red);
          Debuff debuff = new Debuff(1, 5, 1);
          return new Damage(debuff, damage);
        }
        Debuff emptyDebuff = new Debuff(0, 0, 0);
        
        return new Damage(emptyDebuff, damage);
      }

      Console.WriteLine("Feuerball hat verfehlt!");
      return new Damage(0);
    }

    /// <summary>
    /// Heal yourself
    /// </summary>
    /// <returns>A random value between 0 and 15</returns>
    public int SelfHeal(Player player)
    {
      Random random = new Random();
      int result = random.Next(15);

      player.Health += result;

      if(player.Health > 150) 
      {
        result = 150 - player.Health; // Show correct difference when 150 would be exceeded
        player.Health = 150; 

      }

      Helperclass.ChangeConsoleColor($@"Du heiltest dich um {result}!", ConsoleColor.Green);
      return result;
    }
  }
}
