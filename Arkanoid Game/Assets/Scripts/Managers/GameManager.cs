using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Scene Names
    private const string FirstLevel = "Level One";
    private const string SecondLevel = "Level Two";
    private const string MainMenu = "Main Menu";

    // Constant Time values
    private const int PauseGame = 0;
    private const int UnpauseGame = 1;

    private void OnEnable()
    {
        SubscribeEvents();
    }

    private void SubscribeEvents()
    {
        GameEvents.StartGame += StartGame;
        GameEvents.MainMenu += LoadMainMenu;
        GameEvents.LoadNextLevel += LoadNextLevel;
        GameEvents.ReloadGame += ReloadLevel;
        GameEvents.ExitGame += ExitGame;
        GameEvents.GameOver += GameOver;
    }

    private void StartGame()
    {
        UnPauseGame();
        SceneManager.LoadScene(FirstLevel);
    }

    private void LoadMainMenu()
    {
        SceneManager.LoadScene(MainMenu);
    }

    private void UnPauseGame()
    {
        Time.timeScale = UnpauseGame;
    }

    private void PauseGameTime()
    {
        Time.timeScale = PauseGame;
    }    

    private void LoadNextLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name != SecondLevel)
        {
            SceneManager.LoadScene(SecondLevel);
        }
        else
        {
            SceneManager.LoadScene(FirstLevel);
        }

        UnPauseGame();
    }

    private void GameOver()
    {
        PauseGameTime();
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    private void ReloadLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
        UnPauseGame();
    }
    private void OnDisable()
    {
        UnsubscribeEvents();
    }

    private void UnsubscribeEvents()
    {
        GameEvents.StartGame -= StartGame;
        GameEvents.MainMenu -= LoadMainMenu;
        GameEvents.LoadNextLevel -= LoadNextLevel;
        GameEvents.ReloadGame -= ReloadLevel;
        GameEvents.ExitGame -= ExitGame;
        GameEvents.GameOver -= GameOver;
    }
}
