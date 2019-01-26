using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryComponent : MonoBehaviour
{
    public List<GameObject> contents;

    public void AddItem(GameObject itemToAdd)
    {
        contents.Add(itemToAdd);
    }

    public void RemoveAndDestroyItem(GameObject itemToDestroy)
    {
        contents.Remove(itemToDestroy);
        Destroy(itemToDestroy);
    }

    public void RemoveItem(GameObject itemToRemove)
    {
        contents.Remove(itemToRemove);
    }
}
