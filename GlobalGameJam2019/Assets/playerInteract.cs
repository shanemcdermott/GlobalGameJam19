using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteract : MonoBehaviour
{
    public Player player;
    public float pickupDistance = 2.0f;
    public PickupComponent pickup; //nearest object
    public ObjectivesManager objectivesManager;
    int pickupTick = 0; //reduce rate that pickup objects are checked for
    void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        /*  if(Input.GetButtonDown(interactButton))
          {
              Debug.Log("INTERACT");
          }*/
        if(pickupTick % 10==0)
        {
            checkForPickups();
            checkForOutOfRange();
        }

        pickupTick++;

        if (Input.GetAxis("Interact") > 1 || Input.GetKeyDown(KeyCode.J)) 
        {
            if (pickup != null)
            {
                pickup.Interact(player);
                pickup = null;
            }
        }
    }

    private void checkForPickups()
    {
        foreach (ObjectiveComponent o in objectivesManager.Objectives)
        {
            if (o.isActiveAndEnabled)
            {

                if (o.GetComponent<PickupComponent>())
                {
                    Vector2 oPosition = o.transform.position;
                    float distance = Vector2.Distance(transform.position, oPosition);
                    if (distance <= pickupDistance)
                    {
                        Debug.Log("Can be picked up!");
                        pickup = o.GetComponent<PickupComponent>();
                    }
                }
            }
        }
    }

    private void checkForOutOfRange()
    {
        if (pickup == null) return;
        Vector2 oPosition = pickup.transform.position;
        float distance = Vector2.Distance(transform.position, oPosition);
        if (distance > pickupDistance)
        {
            Debug.Log("Out of range!");
            pickup = null;
        }
    }


}
