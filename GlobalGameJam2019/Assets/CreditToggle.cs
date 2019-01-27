using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggle()
    {

        gameObject.SetActive(!gameObject.active);
    }
}
