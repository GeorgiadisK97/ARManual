using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManualHandler : MonoBehaviour
{
    private SwitchSelectorScript _variable1;
    public GameObject manualText, textPi;
    void Start()
    {
        _variable1 = GameObject.Find("SwitchSelectorScript").GetComponent<SwitchSelectorScript>();

        manualText.SetActive(false);
        textPi.SetActive(false);
    }

   
    void Update()
    {
        if (_variable1.dropdown.value == 3)
        {
            textPi.SetActive(true);
            manualText.SetActive(true);
        }
        else
        {
            textPi.SetActive(false);
            manualText.SetActive(false); 
        }
                  
    }
}
