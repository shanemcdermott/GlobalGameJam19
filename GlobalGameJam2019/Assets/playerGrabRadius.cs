using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGrabRadius : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;
        Debug.Log(obj);
        if(obj.GetComponent<PickupObjective>())
        {
            Debug.Log("Is An Objective");
        }
    }
}
