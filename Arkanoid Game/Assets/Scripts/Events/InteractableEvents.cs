using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InteractableEvents
{
    public delegate void InteractableEvent();
    public static event InteractableEvent HealthPickUp;
    public static event InteractableEvent LargerPlatform;
    public static event InteractableEvent SmallerPlatform;

    public static void OnHealthPickUp()
    {
        if (HealthPickUp != null)
        {
            HealthPickUp();
        }
    }

    public static void OnLargerPlatform()
    {
        if (LargerPlatform != null)
        {
            LargerPlatform();
        }
    }

    public static void OnSmallerPlatform()
    {
        if (SmallerPlatform != null)
        {
            SmallerPlatform();
        }
    }
}
