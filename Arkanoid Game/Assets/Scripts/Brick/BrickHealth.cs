using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum BrickHealthStatus
{
    MinHealth = 1,
    MidHealth = 2,
    MaxHealth = 3
}

[RequireComponent(typeof(BoxCollider2D))]
public class BrickHealth : MonoBehaviour
{
    private const int CorrectInclusiveNumber = 1;

    [SerializeField]
    private BrickStats _brickStats;
    [SerializeField]
    private UnityEvent _triggerInteractableDrop;

    private SpriteRenderer _spriteRenderer;
    private BrickHealthStatus _brickHealthStatus;
    private int _currentBrickHealth;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InitializeBrick();
    }

    public void TakeDamage()
    {
        _currentBrickHealth--;

        if (_currentBrickHealth <= 0)
        {
            DestroyBrick();
        }

        SetBrickColor();
    }

    private void DestroyBrick()
    {
        BrickEvents.OnBrickDestroyed();
        Destroy(gameObject);
        _triggerInteractableDrop?.Invoke();
    }

    private void InitializeBrick()
    {
        _currentBrickHealth = Random.Range(_brickStats.MinBrickHealth, _brickStats.MaxBrickHealth + CorrectInclusiveNumber);
        SetBrickColor();
        BrickEvents.OnBrickCreated();
    }

    private void SetBrickColor()
    {
        _brickHealthStatus = (BrickHealthStatus)_currentBrickHealth;
        switch (_brickHealthStatus)
        {
            case BrickHealthStatus.MinHealth:
                this._spriteRenderer.color = _brickStats.LowBrickColor;
                break;
            case BrickHealthStatus.MidHealth:
                this._spriteRenderer.color = _brickStats.MidHealthColor;
                break;
            case BrickHealthStatus.MaxHealth:
                this._spriteRenderer.color = _brickStats.MaxHealthColor;
                break;
            default:
                break;
        }
    }
}
