using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [Header("Start Game Panel")]
    [SerializeField]
    private GameObject _startGamePanel;
    [SerializeField]
    private Button _startGameButton;
    [SerializeField]
    private Button _exitButton;

    private void Start()
    {
        InitializeButtons();
    }

    private void InitializeButtons()
    {
        _startGameButton.onClick.AddListener(StartGame);
        _exitButton.onClick.AddListener(ExitGame);
    }

    private void StartGame()
    {
        GameEvents.OnStartGame();
    }

    private void ExitGame()
    {
        GameEvents.OnExitGame();
    }
}
