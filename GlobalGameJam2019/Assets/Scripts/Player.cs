using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 move;
    public Animator anim;
    public float speed = 1;
    public AudioClip[] openings;
    public AudioClip[] deaths;
    public AudioSource aud;
    bool isMove = false;
    //public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Woop");
        aud = GetComponent<AudioSource>();
        aud.clip = openings[Random.Range(0, openings.Length)];
        aud.Play();
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
        aud.clip = deaths[Random.Range(0, deaths.Length)];
        aud.volume =0.5f;
        aud.Play();
       // aud.volume = 1;
        Debug.Log("Player is dead!");
        GameManager.Get().GameOver();
    }
}
