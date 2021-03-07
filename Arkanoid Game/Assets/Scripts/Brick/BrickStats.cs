using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class BrickStats 
{
    [SerializeField]
    private int _minBrickHealth;
    [SerializeField]
    private int _maxBrickHealth;
    [SerializeField]
    private Color _lowHealthColor;
    [SerializeField]
    private Color _midHealthColor;
    [SerializeField]
    private Color _maxHealthColor;

    public int MinBrickHealth { get => _minBrickHealth; }
    public int MaxBrickHealth { get => _maxBrickHealth; }
    public Color LowBrickColor { get => _lowHealthColor; }
    public Color MidHealthColor { get => _midHealthColor; }
    public Color MaxHealthColor { get => _maxHealthColor; }
}
