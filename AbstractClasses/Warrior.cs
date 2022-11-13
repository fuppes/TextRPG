using OOP_Vererbung.Attack;

namespace OOP_Vererbung.AbstractClasses
{
  internal abstract class Warrior
  {
    public const int HealthModificator = 5;

    /// <summary>
    /// A mighty Axe is flying towards your enemy
    /// </summary>
    /// <returns></returns>
    public Damage ThrowAxe()
    {
      Random random = new Random();

      int chanceToHitTarget = random.Next(100) % 7;

      if (chanceToHitTarget == 0)
      {
        int damage = random.Next(10);
        Console.WriteLine($@"Die Axt richtete {damage} Schaden an.");

        int chanceForBleeding = random.Next(0, 100);
        chanceForBleeding = chanceForBleeding % 2;

        if (chanceForBleeding == 0)
        {
          Console.WriteLine("Die Axt verursachte Blutungsschaden.");
          Debuff debuff = new Debuff(1, 4, 1);
          return new Damage(debuff, damage);
        }

        Debuff emptyDebuff = new(0, 0, 0);
        return new Damage(damage);
      }

      Console.WriteLine("Axt hat verfehlt.");
      return new Damage(0);
    }

    /// <summary>
    /// Block damage completely but n
    /// </summary>
    /// <param name="damage"></param>
    /// <returns></returns>
    public static Damage BlockDamage(Damage damage)
    {
      Damage blockedDamage = new Damage(damage.DirectDamage * 0);
      Console.WriteLine("Direkter Schaden wurde geblockt.");
      return blockedDamage;
    }
  }
}
