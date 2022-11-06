﻿using OOP_Vererbung.Attack;
using OOP_Vererbung.Models;
using OOP_Vererbung.Structs;

namespace OOP_Vererbung
{
  internal class Fight
  {
    private Player _player;
    private Enemy _enemy;

    /// <summary>
    /// Initiate the fight
    /// </summary>
    /// <param name="player"></param>
    /// <param name="enemy"></param>
    public Fight(Player player, Enemy enemy)
    {
      _player = player;
      _enemy = enemy;
    }

    /// <summary>
    /// The casual fight loop, which ends when a opponent got no healthpoints left
    /// </summary>
    public void FightLoop()
    {
      while(_player.Health > 0 && _enemy.Health > 0)
      {
        Console.Clear();
        OpponentsAction opponentsAction = new OpponentsAction(PlayersTurn(), EnemyTurn());
        ProceedTurns(opponentsAction);
        Helperclass.ChangeConsoleColor("Drücke Enter um fortzufahren.", ConsoleColor.Cyan);
        Console.ReadLine();
      }
    }

    /// <summary>
    /// The choice the player is making
    /// </summary>
    public int PlayersTurn()
    {
      Console.WriteLine("Bitte wähle eine Aktion aus:\n1. Feuerball\n2. Selbstheilung");
      int result = Convert.ToInt32(Console.ReadLine());

      if(result == 1 || result == 2)
      {
        return result;
      }
      return PlayersTurn();
    }

    /// <summary>
    /// The random choice the enemy is making
    /// </summary>
    public int EnemyTurn()
    {
      Random random = new Random();

      // 66% for blocking the next attack
      int result = random.Next(1, 3);

      if(result == 1)
      {
        return 1; // Attack
      }
      return 2; // Block
    }

    /// <summary>
    /// The result of PlayersTurn and EnemyTurn
    /// </summary>
    public void ProceedTurns(OpponentsAction opponentsAction)
    {
      Damage damageToEnemy;
      Damage damageToPlayer;

      if(opponentsAction.PlayersAction == 1)
      {
        damageToEnemy = _player.CastFireball();
      }
      else
      {
        _player.SelfHeal(_player);
      }

      if(opponentsAction.EnemysAction == 1)
      {
        damageToPlayer = _enemy.ThrowAxe();
      }
      else
      {
        
      }
    }
  }
}
