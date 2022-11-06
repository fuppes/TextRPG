namespace OOP_Vererbung.Attack
{
  internal class Debuff
  {
    /// <summary>
    /// Amount of stacks of the debuff
    /// </summary>
    public int Stack { get; private set; }
    /// <summary>
    /// The damage of every single stack
    /// </summary>
    public int DamagePerStack { get; private set; }
    /// <summary>
    /// The number of rounds the stacks are ticking
    /// </summary>
    public int StackLifeTime { get; private set; }

    public Debuff(int stack, int damagePerStack, int stackLifeTime)
    {
      SetStack(stack);
      this.DamagePerStack = damagePerStack;
      this.StackLifeTime = stackLifeTime;
    }

    public void SetStack(int stack)
    {
      this.Stack += stack;
    }

    public void SetStackLifeTime(int stackRounds)
    {
      this.StackLifeTime += stackRounds;
      if(this.StackLifeTime <= 0)
      {
        this.Stack = 0;
        this.DamagePerStack = 0;
        this.StackLifeTime = 0;
      }
    }
  }
}
