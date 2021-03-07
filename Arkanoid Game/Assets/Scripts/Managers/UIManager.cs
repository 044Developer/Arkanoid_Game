using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Game Over Panel")]
    [SerializeField]
    private GameObject _gameOverPanel;
    [SerializeField]
    private Button _reloadSceneButton;
    [SerializeField]
    private Button _mainMenuButton;

    private void OnEnable()
    {
        GameEvents.GameOver += OpenGameOverMenu;
    }

    private void Start()
    {
        InitializeButtons();
    }

    private void InitializeButtons()
    {
        _reloadSceneButton.onClick.AddListener(ReloadLevel);
        _mainMenuButton.onClick.AddListener(BackToMainMenu);
    }

    private void ReloadLevel()
    {
        GameEvents.OnReloadGame();
    }

    private void OpenGameOverMenu()
    {
        _gameOverPanel.SetActive(true);
    }

    private void BackToMainMenu()
    {
        GameEvents.OnMainMenu();
    }

    private void OnDisable()
    {
        GameEvents.GameOver -= OpenGameOverMenu;
    }
}
