using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Find8 : MonoBehaviour
{
    public Button button1;
    NextStagePanel nsp;

    void OnEnable()
    {
        //Register Button Events
        button1.onClick.AddListener(() => buttonCallBack(button1));
    }

    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == button1)
        {
            nsp = FindObjectOfType<NextStagePanel>();
            nsp.NextPanel();
        }
    }

    void OnDisable()
    {
        //Un-Register Button Events
        button1.onClick.RemoveAllListeners();
    }


}
