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

    public Button forecastButton;
    public string[] forecastTexts;
    private int forecastIndex = 0;
    public ScrollingDialogue scrollingDialogue;

    // Start is called before the first frame update
    void Start()
    {
        if (scrollingDialogue)
        {
            scrollingDialogue.InitDialogue(forecastTexts[forecastIndex]);
        }
    }

    public void NextNews()
    {
        forecastIndex++;
        if(forecastIndex<forecastTexts.Length)
        {
            scrollingDialogue.AddDialogue(forecastTexts[forecastIndex]);
        }
        else
        {
            HideForecast();
        }
    }

    public void HideForecast()
    {
        forecastButton.gameObject.SetActive(false);
        forecastButton.enabled = false;
        scrollingDialogue.text.enabled = false;
        scrollingDialogue.enabled = false;
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
