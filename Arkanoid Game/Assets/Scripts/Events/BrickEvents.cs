using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BrickEvents 
{
    public delegate void BrickEvent();
    public static event BrickEvent BrickCreated;
    public static event BrickEvent BrickDestroyed;

    public static void OnBrickCreated()
    {
        if (BrickCreated != null)
        {
            BrickCreated();
        }
    }

    public static void OnBrickDestroyed()
    {
        if (BrickDestroyed != null)
        {
            BrickDestroyed();
        }
    }
}
