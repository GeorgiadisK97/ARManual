using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHandler : MonoBehaviour
{
    private SwitchSelectorScript _variable3;


    public void DisplayOn()
    {
        _variable3.raspberry.SetActive(true);
        _variable3.canvas.SetActive(true);
        for (int i = 0; i < _variable3.switchesList.Length; i++)
            _variable3.switchesList[i].SetActive(true);
        if (_variable3.a >= 6)
        {
            _variable3.charger.SetActive(true);
        }
    }
    public void DisplayOff()
    {
        _variable3.charger.SetActive(false);
        _variable3.raspberry.SetActive(false);
        _variable3.canvas.SetActive(false);
        for (int i = 0; i < _variable3.switchesList.Length; i++)
            _variable3.switchesList[i].SetActive(false);
    }

    void Start()
    {
        _variable3 = GameObject.Find("SwitchSelectorScript").GetComponent<SwitchSelectorScript>();
    }

    void Update()
    {
        
    }
}
