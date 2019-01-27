using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    public GameObject targetToToggle;

    public void ToggleObject()
    {
        if (targetToToggle)
        {
            targetToToggle.SetActive(!targetToToggle.active);
        }
    }
}
