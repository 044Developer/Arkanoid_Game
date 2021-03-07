using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class BallStats
{
    [Header("Physics Stats")]
    [SerializeField]
    private float _ballForce;
    [SerializeField]
    private float _minAngleForce;
    [SerializeField]
    private float _maxAngleForce;

    public float BallForce { get => _ballForce; }
    public float MinAngleForce { get => _minAngleForce; }
    public float MaxAngleForce { get => _maxAngleForce; }
}
