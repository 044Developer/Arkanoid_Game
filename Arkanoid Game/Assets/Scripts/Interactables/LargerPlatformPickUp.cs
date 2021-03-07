using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Pick Up/Larger Platform")]
public class LargerPlatformPickUp : PickUpInteractable
{
    public override void Apply()
    {
        InteractableEvents.OnLargerPlatform();
    }
}
