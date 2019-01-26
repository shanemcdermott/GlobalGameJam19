using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 move;
    public Animator anim;
    public float speed = 1;
    bool isMove = false;
    //public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Woop");

    }

    // Update is called once per frame
    void Update()
    {
        isMove = false; //presumed not moving until proven otherwise

        move.y = Input.GetAxis("Vertical");
        move.x = Input.GetAxis("Horizontal");
        if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {          
            isMove = true;
        }
       

        transform.Translate(move * speed);
        if (isMove)
        {
          //  Debug.Log("Move!");
            anim.SetTrigger("Walk");
        }
        else
        {
            anim.SetTrigger("Stop");
           // Debug.Log("Don't move!");
        }



    }

    
    public void Die()
    {
        Debug.Log("Player is dead!");
        GameManager.Get().GameOver();
    }
}
