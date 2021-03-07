using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableController : MonoBehaviour
{
    [SerializeField]
    private PickUpInteractable _interactable;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(_interactable.PlatformTag))
        {
            _interactable.Apply();
            Destroy(this.gameObject);
        }
    }
}
