using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class PickUpInteractable : ScriptableObject
{
    private const string PlatformName = "Platform";
    public string PlatformTag { get => PlatformName; }
    public abstract void Apply();
}
