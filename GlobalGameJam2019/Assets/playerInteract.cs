using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteract : MonoBehaviour
{
    public Player player;
    //public float pickupDistance = 2.0f;
    public PickupComponent pickup; //nearest object
    public ObjectivesManager objectivesManager;
    public UIMaster uiMaster;
  //  int pickupTick = 0; //reduce rate that pickup objects are checked for
    void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
       

       // pickupTick++;

        if (Input.GetAxis("Interact") > 1 || Input.GetKeyDown(KeyCode.J)) 
        {
            if (pickup != null)
            {
                pickup.Interact(player);
                pickup = null;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        PickupComponent p = collision.gameObject.GetComponent<PickupComponent>();
        if(p != null)
            pickup = p;

        uiMaster.activateItemText(p);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PickupComponent p = collision.gameObject.GetComponent<PickupComponent>();
        if (p != null)
            if (pickup == p)
                pickup = null;
        uiMaster.disableItemText();
    }

}
