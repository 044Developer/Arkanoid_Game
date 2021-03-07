using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlatformStats 
{
    [Header("Transform Stats")]
    [SerializeField] 
    private float _moveSpeed;
    [SerializeField] 
    private float _minXPosition;
    [SerializeField] 
    private float _maxXPosition;
    [SerializeField]
    private float _sizeChangeDamper;

    [Header("DoTween Stats")]
    [SerializeField]
    private float _timeDuration;
    [SerializeField]
    private float _strength;

    public float MoveSpeed { get => _moveSpeed; }
    public float MinXPosition { get => _minXPosition; }
    public float MaxXPosition { get => _maxXPosition; }
    public float TweenTimeDuration { get => _timeDuration; }
    public float TweenStrength { get => _strength; }
    public float SizeChangeDamper { get => _sizeChangeDamper; }
}
