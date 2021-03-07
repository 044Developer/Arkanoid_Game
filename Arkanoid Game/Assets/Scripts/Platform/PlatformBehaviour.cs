using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D))]
public class PlatformBehaviour : MonoBehaviour
{
    [SerializeField] 
    private PlatformStats _platformStats;

    private PlatformController _moveController;
    private float _screenWidth;

    private void OnEnable()
    {
        SubscribeEvents();
    }

    private void SubscribeEvents()
    {
        InteractableEvents.LargerPlatform += IncreasePlatformSize;
        InteractableEvents.SmallerPlatform += DecreasePlatformSize;
    }

    private void Start()
    {
        _screenWidth = Screen.width;
        _moveController = new PlatformController(_platformStats, transform, _screenWidth);
    }

    private void Update()
    {
        _moveController.PCMove();
        _moveController.MobileMove();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _moveController.Shake();
    }

    private void IncreasePlatformSize()
    {
        Vector2 newSize = new Vector2(transform.localScale.x + _platformStats.SizeChangeDamper, transform.localScale.y);
        transform.localScale = newSize;
    }

    private void DecreasePlatformSize()
    {
        Vector2 newSize = new Vector2(transform.localScale.x - _platformStats.SizeChangeDamper, transform.localScale.y);
        transform.localScale = newSize;
    }

    private void OnDisable()
    {
        UnsubscribeEvents();
    }

    private void UnsubscribeEvents()
    {
        InteractableEvents.LargerPlatform -= IncreasePlatformSize;
        InteractableEvents.SmallerPlatform -= DecreasePlatformSize;
    }
}
