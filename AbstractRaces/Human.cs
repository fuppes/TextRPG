using OOP_Vererbung.AbstractClasses;
using OOP_Vererbung.Interface;

namespace OOP_Vererbung.Abstract
{
  internal abstract class Human : Mage, IAlliance
  {
    public void EnterAllianceCities()
    {
      Console.WriteLine("Welcome to [AllianceOutpost]!\nWe won't attack you!");
    }

    public void EnterHordeCities()
    {
      Console.WriteLine("You are at [HordeOutpost]!\nBeware, we will attack you!");
    }

    public void FlyToAllianceOutposts(List<string> availableOutposts)
    {
      foreach (string outpost in availableOutposts)
      {
        Console.WriteLine(outpost);
      }  
    }
  }
}
