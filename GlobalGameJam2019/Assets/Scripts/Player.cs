using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Wop");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Transform.X += 1;
    }
}
