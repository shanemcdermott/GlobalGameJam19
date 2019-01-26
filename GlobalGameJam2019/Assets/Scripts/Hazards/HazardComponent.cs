﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardComponent : MonoBehaviour
{
    public Vector2 size;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rigidBody;

    void Awake()
    {
        if (boxCollider == null)
        {
            boxCollider = gameObject.AddComponent<BoxCollider2D>();
            boxCollider.size = size;
            boxCollider.isTrigger = true;
        }
        if(rigidBody == null)
        {
            rigidBody = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
            rigidBody.gravityScale = 0;
           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Something collided!");
        Player player = collision.gameObject.GetComponent<Player>();
        if (player)
        {
            player.Die();
        }
    }
}