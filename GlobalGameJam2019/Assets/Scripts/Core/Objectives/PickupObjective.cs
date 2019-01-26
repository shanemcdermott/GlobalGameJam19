using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjective : ObjectiveComponent
{
    public PickupComponent pickupComponent;


    private bool bIsListeningToPickup = false;

    // Start is called before the first frame update
    void Start()
    {
        if(pickupComponent && !bIsListeningToPickup)
        {
            pickupComponent.OnItemPickup.AddListener(RespondToObjectivePickup);
            bIsListeningToPickup = true;
        }
    }

    void RespondToObjectivePickup(GameObject pickedUpObjective)
    {
        OnObjectiveComplete.Invoke(this);
    }
}
