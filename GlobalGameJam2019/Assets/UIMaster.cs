using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMaster : MonoBehaviour
{
    public Text text;
    public Button restartButton;
    public RectTransform deathPanel;
    public Text deathText;
    public Text objectiveText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateItemText(PickupComponent p)
    {
        text.text = "Press \"J\" to pick up " + p.itemName;
        text.enabled = true;
    }

    public void disableItemText()
    {
        text.enabled = false;
    }
    public void updateObjectiveText(int x, int y)
    {
        objectiveText.text = x + "/" + y;
    }
}
