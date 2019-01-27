using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBounds : MonoBehaviour
{
    public BoxCollider2D boundsCollider;

    private void OnTriggerExit2D(Collider2D collision)
    {
        Player p = collision.gameObject.GetComponent<Player>();
        if (p)
        {
            p.Die();
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
