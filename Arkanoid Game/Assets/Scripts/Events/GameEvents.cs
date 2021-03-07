using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents
{
    public delegate void GameEvent();
    public static event GameEvent BallDeath;
    public static event GameEvent StartGame;
    public static event GameEvent MainMenu;
    public static event GameEvent LoadNextLevel;
    public static event GameEvent ReloadGame;
    public static event GameEvent ExitGame;
    public static event GameEvent GameOver;

    public static void OnBallDeath()
    {
        if (BallDeath != null)
        {
            BallDeath();
        }
    }

    public static void OnMainMenu()
    {
        if (MainMenu != null)
        {
            MainMenu();
        }
    }

    public static void OnStartGame()
    {
        if (StartGame != null)
        {
            StartGame();
        }
    }

    public static void OnLoadNextLevel()
    {
        if (LoadNextLevel != null)
        {
            LoadNextLevel();
        }
    }
    
    public static void OnReloadGame()
    {
        if (ReloadGame != null)
        {
            ReloadGame();
        }
    }
    public static void OnExitGame()
    {
        if (ExitGame != null)
        {
            ExitGame();
        }
    }

    public static void OnGameOver()
    {
        if (GameOver != null)
        {
            GameOver();
        }
    }
}
