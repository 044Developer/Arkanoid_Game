using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Pick Up/Smaller Platform")]
public class SmallerPlatformPickUp : PickUpInteractable
{
    public override void Apply()
    {
        InteractableEvents.OnSmallerPlatform();
    }
}
