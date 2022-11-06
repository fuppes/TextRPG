using OOP_Vererbung;
using OOP_Vererbung.Models;

public static class Program
{
  public static void Main()
  {
    Player player = InitPlayerCharacter();
    Console.WriteLine($@"Willkommen {player.Name}!");
    Enemy enemy = InitEnemyCharacter();
    
    Helperclass.ChangeConsoleColor("Drücke Enter um fortzufahren.", ConsoleColor.Cyan);
    Console.ReadLine();
    Console.Clear();
    ProvideCharacterInformation(player, enemy);
    Fight fight = new Fight(player, enemy);
    fight.FightLoop();
  }

  internal static void ProvideCharacterInformation(Player player, Enemy enemy)
  {
    Console.WriteLine($@"Du spielst einen menschlichen Magier mit dem Angriff Feuerball und Selbstheilung.
                      {Environment.NewLine}Dein Name ist {player.Name} und du hast {player.Health} Lebenspunkte.");
    Console.WriteLine($@"{Environment.NewLine}Dein Gegner heißt {enemy.Name} und ist ein Ork-Krieger. Dieser hat {enemy.Health} Lebenspunkte.
                      {Environment.NewLine}Dein Gegner greift mit Axt-Würfen an oder kann den gesamten, direkten Schaden blockieren.");
    Helperclass.ChangeConsoleColor("Ihr kloppt euch jetzt!", ConsoleColor.Red);
    Helperclass.ChangeConsoleColor("Drücke Enter um fortzufahren.", ConsoleColor.Cyan);
    Console.ReadLine();
    Console.Clear();
  }

  internal static Player InitPlayerCharacter()
  {
    Console.WriteLine("Willkommen im RPG Kampfsimulator!\nWie heißt ihr Charakter?");
    string? playername = Console.ReadLine();

    return new Player(playername);
  }

  internal static Enemy InitEnemyCharacter()
  {
    Console.WriteLine("Wie heißt ihr Gegenspieler?");
    string? enemyName = Console.ReadLine();

    return new Enemy(enemyName);
  }
}
