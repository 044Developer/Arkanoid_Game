using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Pick Up/Extra Life")]
public class ExtraLifePickUp : PickUpInteractable
{
    public override void Apply()
    {
        InteractableEvents.OnHealthPickUp();
    }
}
