using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        if(player==null)
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
