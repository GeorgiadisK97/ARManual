using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickRoutine : MonoBehaviour
{
    private SwitchSelectorScript _variable4;


    public void RoutineWrap()
    {
        if (_variable4.dropdown.value == 1)
        {
            if (_variable4.a == 1)
            {
                _variable4.nextButton.interactable = false;
                StartCoroutine(_variable4.Delay1());
            }
            else if (_variable4.a == 2)
            {
                _variable4.nextButton.interactable = false;
                StartCoroutine(_variable4.Delay2());
            }
            else if (_variable4.a == 3)
            {
                _variable4.nextButton.interactable = false;
                StartCoroutine(_variable4.Delay3());
            }
            else if (_variable4.a == 4)
            {
                _variable4.nextButton.interactable = false;
                StartCoroutine(_variable4.Delay4());
            }
            else if (_variable4.a == 5)
            {
                _variable4.nextButton.interactable = false;
                StartCoroutine(_variable4.Delay5());
            }
            else if (_variable4.a == 6)
            {
                _variable4.switchesTags[4].enabled = false;
                _variable4.nextButton.interactable = false;
                _variable4.pass = true;
                StartCoroutine(_variable4.Delay6());
            }
        }
        if (_variable4.dropdown.value == 2)
        {
            if (_variable4.a == 0)
                _variable4.switchesTags[0].enabled = false;
            else if (_variable4.a == 1)
            {
                _variable4.nextButton.interactable = false;
                StartCoroutine(_variable4.Delay1());
            }
            else if (_variable4.a == 2)
            {
                _variable4.nextButton.interactable = false;
                StartCoroutine(_variable4.Delay2());
            }
            else if (_variable4.a == 3)
            {
                _variable4.nextButton.interactable = false;
                StartCoroutine(_variable4.Delay3());
            }
            else if (_variable4.a == 4)
            {
                _variable4.nextButton.interactable = false;
                StartCoroutine(_variable4.Delay4());
            }
            else if (_variable4.a == 5)
            {
                _variable4.nextButton.interactable = false;
                StartCoroutine(_variable4.Delay5());
            }
            else if (_variable4.a == 6)
            {
                _variable4.switchesTags[4].enabled = false;
                _variable4.nextButton.interactable = false;
                _variable4.pass = false;
                StartCoroutine(_variable4.Delay6());
            }
        }
        if (_variable4.state == "OFF" && _variable4.a <= 6 && _variable4.a > 0)
            _variable4.a--;
        else if (_variable4.state == "ON" && _variable4.a <= 6)
        {
            _variable4.a++;
        }
    }

    void Start()
    {
        _variable4 = GameObject.Find("SwitchSelectorScript").GetComponent<SwitchSelectorScript>();
    }

    void Update()
    {
        if (_variable4.dropdown.value == 0)
            _variable4.nextButton.interactable = false;
        else if (_variable4.dropdown.value == 1 && _variable4.isDone == true)
        {
            _variable4.a++;
            _variable4.nextButton.interactable = true;
            _variable4.isDone = false;
            _variable4.state = "ON";
        }
        else if (_variable4.dropdown.value == 2 && _variable4.isDone == false && _variable4.a > 0)
        {
            _variable4.a--;
            _variable4.nextButton.interactable = true;
            _variable4.isDone = true;
            _variable4.state = "OFF";
        }
    }
}
