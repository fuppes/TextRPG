using OOP_Vererbung.AbstractClasses;
using OOP_Vererbung.Interface;

namespace OOP_Vererbung.Abstract
{
  internal abstract class Orc : Warrior, IHorde
  {
    public void EnterAllianceCities()
    {
      throw new NotImplementedException();
    }

    public void EnterHordeCities()
    {
      throw new NotImplementedException();
    }

    public void FlyToHordeOutposts(List<string> availableOutposts)
    {
      throw new NotImplementedException();
    }
  }
}
