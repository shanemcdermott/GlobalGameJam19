using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalMovement : MonoBehaviour
{

    public Vector2 direction = new Vector2(0,1);
    public float speed = 1;


    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        gameObject.transform.Translate(direction * speed * Time.deltaTime);
    }
}
