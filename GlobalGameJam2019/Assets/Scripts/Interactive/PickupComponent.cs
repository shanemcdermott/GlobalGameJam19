using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickupEvent : UnityEvent<GameObject>
{ }

public class PickupComponent : MonoBehaviour, Interactive
{
    public bool bShouldDeactivateOnPickup = true;

    public PickupEvent OnItemPickup = new PickupEvent();


    private void Awake()
    {

    }

    public void Interact(Player inPlayer)
    {
        InventoryComponent inventory = inPlayer.GetComponent<InventoryComponent>();
        if (inventory)
        {
            inventory.AddItem(gameObject);
            OnItemPickup.Invoke(gameObject);
            gameObject.SetActive(!bShouldDeactivateOnPickup);
        }
        else
        {
            Debug.Log("ERROR: player inventory not found!");
        }
    }

}
