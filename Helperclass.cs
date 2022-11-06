namespace OOP_Vererbung
{
  internal static class Helperclass
  {
    /// <summary>
    /// Change the fontcolor and return to white after that
    /// </summary>
    /// <param name="text"></param>
    /// <param name="color"></param>
    public static void ChangeConsoleColor(string text, ConsoleColor color)
    {
      Console.ForegroundColor = color;
      Console.WriteLine(text);
      Console.ForegroundColor = ConsoleColor.White;
    }
  }
}
