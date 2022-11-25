namespace OOP_Vererbung.Structs
{
  public struct OpponentsAction
  {
    public int? PlayersAction { get; }
    public int EnemysAction { get; }

    public OpponentsAction(int? playersAction, int enemysAction)
    {
      PlayersAction = playersAction;
      EnemysAction = enemysAction;
    }
  }
}
