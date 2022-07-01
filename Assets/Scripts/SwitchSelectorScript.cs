using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwitchSelectorScript : MonoBehaviour
{
    public int a;
    public string state = "ON";
    public TextMeshPro text;
    public TextMeshPro[] switchesTags;
    public bool pass = true, isDone = true;
    public Dropdown dropdown;
    public Button nextButton;
    public Vector3 offset;
    public GameObject raspberry, canvas, charger;
    public GameObject[] switchesList;
    readonly List<Animator> animatorList = new List<Animator>();
    public Transform target;

    void Start()
    {
        text.enabled = false;
        canvas.SetActive(false);
        charger.SetActive(false);
        raspberry.SetActive(false);
        nextButton.enabled = true;

        a = 0;
        if (switchesTags.Length >=1)
        {
            for (int i = 0; i < switchesTags.Length; i++)
            {
                switchesTags[i].enabled = false;
            }
        }
        if (switchesList.Length >= 1)
        {
            for (int i = 0; i < switchesList.Length; i++)
            {
                animatorList.Add(switchesList[i].GetComponent<Animator>());
                animatorList[i].enabled = false;
                switchesList[i].SetActive(false);
            }
        }
        else
            return;
    }
    void Update()
    {

    }
    public IEnumerator Delay1()
    {
        yield return new WaitForSeconds(0.5f);
        FindSwitch("Asfaliodiakoptis1");    
        nextButton.interactable = true;
    }
    public IEnumerator Delay2()
    {
        yield return new WaitForSeconds(0.5f);
        FindSwitch("Asfaliodiakoptis2");
        
       nextButton.interactable = true;
    }
    public IEnumerator Delay3()
    {
        yield return new WaitForSeconds(0.5f);
        FindSwitch("Asfaliodiakoptis3");
        
        nextButton.interactable = true;
    }
    public IEnumerator Delay4()
    {
        yield return new WaitForSeconds(0.5f);
        FindSwitch("Asfaliodiakoptis4");
        
        nextButton.interactable = true;
    }
    public IEnumerator Delay5()
    {
        yield return new WaitForSeconds(0.5f);
        FindSwitch("DiplosAsfaliodiakoptis");
        nextButton.interactable = true;
    }
    public IEnumerator Delay6()
    {
        yield return new WaitForSeconds(0.5f);
        charger.SetActive(pass);
        nextButton.interactable = true;
    }
    public IEnumerator InfoRoutine()
    {
        yield return new WaitForSeconds(5f);
    }
    public int SendA(int a)
    {
        return a;
    }
    public void FindSwitch(string switchName)
    {
        if (switchesList.Length >= 1)
        {
            for (int i = 0; i < switchesList.Length; i++)
            {
                if (switchesList[i].name == switchName)
                {
                    animatorList[i].enabled = true;
                    animatorList[i].SetTrigger(state);
                    switchesTags[i].enabled = true;
                }
                else
                    switchesTags[i].enabled = false;
            }
        }
        else
        {
            return;
        }
    }
}


