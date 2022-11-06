namespace OOP_Vererbung.Attack
{
  internal class Damage
  {
    /// <summary>
    /// Debuffs which effect the opponent
    /// </summary>
    public Debuff Debuff { get; private set; }
    /// <summary>
    /// Damage dealt to the opponent
    /// </summary>
    public int DirectDamage { get; private set; }

    /// <summary>
    /// Constructor to deal damage and apply a debuff
    /// </summary>
    /// <param name="debuff"></param>
    /// <param name="directDamage"></param>
    public Damage(Debuff debuff, int directDamage)
    {
      this.Debuff = debuff;
      this.DirectDamage = directDamage;
    }

    public Damage(int directDamage)
    {
      this.DirectDamage = directDamage;
    }
  }
}
