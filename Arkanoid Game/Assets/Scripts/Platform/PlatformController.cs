using DG.Tweening;
using UnityEngine;

public class PlatformController
{
    private const int HalfScreen = 2;
    private const int FirstTouch = 0;

    private PlatformStats _platformStats;
    private Transform _platformTransform;
    private Vector3 _currentTransform;
    private float _screenWidth;

    public PlatformController(PlatformStats platformStats, Transform platformTransform, float screenWidth)
    {
        _platformStats = platformStats;
        _platformTransform = platformTransform;
        _currentTransform.y = _platformTransform.localPosition.y;
        _screenWidth = screenWidth;
    }
    public void Shake()
    {
        _platformTransform.DOShakeScale(_platformStats.TweenTimeDuration, _platformStats.TweenStrength);
    }

    public void PCMove()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && CheckLeftBorder())
        {
            MoveLeft();
        }
        else if (Input.GetKey(KeyCode.RightArrow) && CheckRightBorder())
        {
            MoveRight();
        }
    }

    public void MobileMove()
    {
        if (Input.touchCount > 0)
        {
            Touch newTouch = Input.GetTouch(FirstTouch);
            if ((newTouch.position.x < _screenWidth / HalfScreen) && CheckLeftBorder())
            {
                MoveLeft();
            }
            else if((newTouch.position.x > _screenWidth / HalfScreen) && CheckRightBorder())
            {
                MoveRight();
            }
        }
    }

    private bool CheckLeftBorder()
    {
        return (_platformTransform.localPosition.x > _platformStats.MinXPosition);
    }

    private bool CheckRightBorder()
    {
        return (_platformTransform.localPosition.x < _platformStats.MaxXPosition);
    }

    private void MoveLeft()
    {
        _platformTransform.Translate(Vector2.left * _platformStats.MoveSpeed * Time.deltaTime);
    }

    private void MoveRight()
    {
        _platformTransform.Translate(Vector2.right * _platformStats.MoveSpeed * Time.deltaTime);
    }
}
