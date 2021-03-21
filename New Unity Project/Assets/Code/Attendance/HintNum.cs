using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintNum : MonoBehaviour {

    public Text hintNum;

    int hint = 0;

    void Start()
    {
        hintNum.text = "0";
        Debug.Log(System.DateTime.Now);
    }
    void Update()
    {
    }
    public void Hint1Plus()
    {
        hint += 1;
        hintNum.text = hint.ToString();
    }
    public void Hint2Plus()
    {
        hint += 2;
        hintNum.text = hint.ToString();
    }
    public void HintRandomPlus()
    {
        int random = Random.Range(2, 5);
        if (random == 2)
        {
            Hint2Plus();
        }
        else if (random == 3)
        {
            hint += 3;
            hintNum.text = hint.ToString();
        }
        else if (random == 4)
        {
            hint += 4;
            hintNum.text = hint.ToString();
        }
    }
}
