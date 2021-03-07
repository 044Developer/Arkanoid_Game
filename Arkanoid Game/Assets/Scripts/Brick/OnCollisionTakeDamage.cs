using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionTakeDamage : MonoBehaviour
{
    private const string BallTag = "Ball";

    [SerializeField]
    private UnityEvent OnBrickDestroyed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(BallTag))
        {
            OnBrickDestroyed?.Invoke();
        }
    }
}
