using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickUpObject : MonoBehaviour
{
    private const int MaxDropChance = 101;

    [SerializeField]
    private List<GameObject> _pickUpObject;
    [SerializeField]
    private int _chanceOfDrop;

    public void CheckChanceOfDrop()
    {
        int randomNumber = Random.Range(0, MaxDropChance);

        if (randomNumber <= _chanceOfDrop)
        {
            SpawnInteractable();
        }
    }

    private void SpawnInteractable()
    {
        var indexOfInteractable = Random.Range(0, _pickUpObject.Count);
        Instantiate(_pickUpObject[indexOfInteractable], transform.position, Quaternion.identity);
    }
}
