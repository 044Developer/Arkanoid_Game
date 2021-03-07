using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController
{
    private const int LeftMouseButton = 0;

    private GameObject _ballObject;
    private Transform _platformTransform;
    private BallStats _ballStats;
    private Rigidbody2D _rigidbody;
    private bool _isBallActive;

    public BallController(GameObject ball, Transform platformTransform, Rigidbody2D rigidbody, BallStats ballStats, bool isBallActive)
    {
        _ballObject = ball;
        _platformTransform = platformTransform;
        _ballStats = ballStats;
        _rigidbody = rigidbody;
        _isBallActive = isBallActive;
    }
    public void ReloadPhysic()
    {
        _rigidbody.velocity = Vector2.zero;
        _isBallActive = false;
    }

    public void ControllTheBall()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton) && !_isBallActive)
        {
            LaunchBall();
            _isBallActive = true;
        }

        if (!_isBallActive)
        {
            FollowThePlatform();
        }
    }

    private void LaunchBall()
    {
        float angle = Random.Range(_ballStats.MinAngleForce, _ballStats.MaxAngleForce);
        _rigidbody.AddForce(new Vector2(angle, _ballStats.BallForce));
    }

    private void FollowThePlatform()
    {
        _ballObject.transform.position = new Vector2(_platformTransform.position.x, _ballObject.transform.position.y);
    }
}
