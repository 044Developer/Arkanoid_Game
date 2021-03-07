using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    [Header("Ball Settings")]
    [SerializeField]
    private Transform _ballTransform;
    [SerializeField]
    private Transform _ballSpawnPoint;

    [Header("UI Display")]
    [SerializeField]
    private TextMeshProUGUI _livesText;

    [Header("Player Settings")]
    [SerializeField]
    private PlayerStats _playerSettings;

    private int _bricksCount;
    private int _currentLivesCount;

    private void OnEnable()
    {
        SubscribeEvents();
    }

    private void SubscribeEvents()
    {
        BrickEvents.BrickCreated += AddNewBrick;
        BrickEvents.BrickDestroyed += DestroyBrick;
        GameEvents.BallDeath += TriggerBallRespawn;
        InteractableEvents.HealthPickUp += IncreaseLivesCount;
    }

    private void Start()
    {
        InitializeLevel();
    }

    private void InitializeLevel()
    {
        _currentLivesCount = _playerSettings.LivesCount;
        UpdateUIDisplay();
    }

    private void AddNewBrick()
    {
        _bricksCount++;
    }

    private void DestroyBrick()
    {
        _bricksCount--;
        if (_bricksCount <= 0)
        {
            GameEvents.OnLoadNextLevel();
        }
    }

    private void TriggerBallRespawn()
    {
        StartCoroutine(BallRespawn());
    }

    private IEnumerator BallRespawn()
    {
        ReduceLivesCount();
        var waitTime = new WaitForSeconds(_playerSettings.RespawnTime);
        yield return waitTime;
        _ballTransform.gameObject.SetActive(true);
        _ballTransform.localPosition = _ballSpawnPoint.position;
    }

    private void ReduceLivesCount()
    {
        _currentLivesCount--;

        if (_currentLivesCount <= 0)
        {
            GameEvents.OnGameOver();
        }

        UpdateUIDisplay();
    }

    private void UpdateUIDisplay()
    {
        _livesText.text = _currentLivesCount.ToString();
    }

    private void IncreaseLivesCount()
    {
        if (_currentLivesCount < _playerSettings.MaxLivesCount)
        {
            _currentLivesCount++;
            UpdateUIDisplay();
        }
    }

    private void OnDisable()
    {
        UnsubscribeEvents();
    }

    private void UnsubscribeEvents()
    {
        BrickEvents.BrickCreated -= AddNewBrick;
        BrickEvents.BrickDestroyed -= DestroyBrick;
        GameEvents.BallDeath -= TriggerBallRespawn;
        InteractableEvents.HealthPickUp -= IncreaseLivesCount;
    }
}
