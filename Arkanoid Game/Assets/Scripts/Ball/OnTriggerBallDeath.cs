using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerBallDeath : MonoBehaviour
{
    private const string BallTag = "Ball";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(BallTag))
        {
            collision.gameObject.SetActive(false);
            GameEvents.OnBallDeath();
        }
    }
}
