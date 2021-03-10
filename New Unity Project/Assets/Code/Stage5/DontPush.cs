using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontPush : MonoBehaviour
{
    private float GameTime = 6;
    private float GameTime2 = 1.2f;
    NextStagePanel nsp;
    [SerializeField] private GameObject x;
    Count c = new Count();

    void Start()
    {
        x.gameObject.SetActive(false);
    }

    void Update()
    {
        if (x.activeSelf == true) //1.5f초동안 같은 자리이면 안보이게 하기
        {
            GameTime2 -= Time.deltaTime;
            if ((int)GameTime2 == 0)
            {
                x.gameObject.SetActive(false);
            }
        }


        if ((int)GameTime == 0)
        {
            nsp = FindObjectOfType<NextStagePanel>();
            nsp.NextPanel();
        }
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) //터치가 감지되면
        {
            x.gameObject.SetActive(true);
            c.setCount();
            GameTime = 6;
        }
        else
        {
            GameTime -= Time.deltaTime;
        }

    }
}
