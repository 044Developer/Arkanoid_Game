using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerStats 
{
    [SerializeField]
    private int _livesCount;
    [SerializeField]
    private int _maxLivesCount;
    [SerializeField]
    private float _respawnTime;

    public int LivesCount { get => _livesCount; }
    public int MaxLivesCount { get => _maxLivesCount; }
    public float RespawnTime { get => _respawnTime; }
}
