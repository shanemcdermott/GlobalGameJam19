using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 move;
    public Animator anim;
    public float speed = 1;
    //public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Woop");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("UP");
            move.y = 1;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            //Debug.Log("DOWN");
            move.y = -1;
        }
        else
        {
            //Debug.Log("Stahp");
            move.y = 0;
        }

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("LEFT");
            move.x = -1;
        }     
       else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("RIGHT");
            move.x = 1;
        }
        else
        {
            //Debug.Log("Stahp");
            move.x = 0;
        }

        transform.Translate(move * speed);
    }

    
    public void Die()
    {
        Debug.Log("Player is dead!");
        GameManager.Get().GameOver();
    }
}
