using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{

    GameObject people;
    control peopleControl;

    // Use this for initialization
    void Start()
    {
        people = GameObject.Find("people");
        peopleControl = people.GetComponent<control>();
    }

    public void LeftBtnDown() { peopleControl.LeftMove = true; }
    public void LeftBtnUp() { peopleControl.LeftMove = false; }

    public void RightBtnDown() { peopleControl.RightMove = true; }
    public void RightBtnUp() { peopleControl.RightMove = false; }

    public void UpBtnDown() { peopleControl.UpMove = true; }
    public void UpBtnUp() { peopleControl.UpMove = false; }

    public void DownBtnDown() { peopleControl.DownMove = true; }
    public void DownBtnUp() { peopleControl.DownMove = false; }
}