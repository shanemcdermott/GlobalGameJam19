using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetNode : MonoBehaviour
{
    public TargetNode nextNode;
   // public Vector2 size = new Vector2(0.5f,0.5f);

    //private BoxCollider2D boxCollider;

/*
    void Awake()
    {
        if (boxCollider == null)
        {
            boxCollider = gameObject.GetComponent<BoxCollider2D>();
            if (boxCollider == null)
            {
                boxCollider = gameObject.AddComponent<BoxCollider2D>();
                boxCollider.size = size;
                boxCollider.isTrigger = true;
            }
        }
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(nextNode)
        {
            MoveTowardsTarget mover = collision.gameObject.GetComponent<MoveTowardsTarget>();
            if(mover)
            {
                mover.target = nextNode.transform;
            }
        }
    }
    */
}
