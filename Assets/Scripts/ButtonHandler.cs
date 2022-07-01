using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class ButtonHandler : MonoBehaviour
{
    
    private bool switchText = true;
    private SwitchSelectorScript getA, _variable2;
    public Button infobutton;
    public TextMeshPro displayText;
    public GameObject infoText;
    private string info;
    

    void Start()
    {
        _variable2 = GameObject.Find("SwitchSelectorScript").GetComponent<SwitchSelectorScript>();
        getA = GameObject.Find("SwitchSelectorScript").GetComponent<SwitchSelectorScript>();
        infoText.SetActive(true);
    }
    private void Update()
    {
        if (_variable2.dropdown.value == 0)
        {    
            if (switchText)
                infoText.SetActive(true);
            info = "ELECTRICAL PANEL" +
                " ID:153518 " +
                "Open the menu and select a panel function. Press the information button to close.";
            SetText(info);
            infobutton.interactable = true;
        }
        else if (_variable2.dropdown.value == 1)
        {
            if (switchText)
                infoText.SetActive(true);
            if (getA.SendA(getA.a)==6 || getA.SendA(getA.a)==7)
            {
                infobutton.interactable = false;
                infoText.SetActive(true);
                info = "PANEL ACTIVATED. DANGER PROCEED WITH CARE.";
                SetText(info);
            }
            else
            {
                infobutton.interactable = true;
                info = "PANEL ACTIVATION. Click NEXT to open the switches with order. Press the information button to close.";
                SetText(info);
            }
            
        }
        else if (_variable2.dropdown.value == 2)
        {
            if (switchText)
                infoText.SetActive(true);
            if (getA.SendA(getA.a) == 0)
            {
                infobutton.interactable = false;
                infoText.SetActive(true);
                info = "PANEL DEACTIVATED. PROCEED";
                SetText(info);
            }
            else 
            {
                infobutton.interactable = true;
                info = "PANEL DEACTIVATION. Click NEXT to close the switches with order. Press again to close.";
                SetText(info); 
            }    
        }
        else
        {
            infobutton.interactable = false;
            infoText.SetActive(false);
        }
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void SetText(string text)
    {
        displayText.text = text;
    }
    public void TextHandler()
    {
        switchText = !switchText;          
        if (switchText)
            infoText.SetActive(true);
        else
            infoText.SetActive(false);
        
    }
}


