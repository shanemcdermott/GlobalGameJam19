using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBounds : MonoBehaviour
{
    public BoxCollider2D boundsCollider;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.GetComponent<Player>())
        {
            Destroy(collision.gameObject);
        }
    }
}
