using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSize : MonoBehaviour
{
    Count c = new Count();
    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        //마우스 좌표를 스크린 투 월드로 바꾸고 이 객체의 위치로 설정해 준다.
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

        if (transform.localScale.x > 0.5f && transform.localScale.y > 0.5f)
        {
            if (transform.localPosition.y > -0.2)
            {
                transform.localPosition = new Vector3(-0.012f, -1.802f, 1);
            }
        }
            
            
        
    }

    private float initTouchDist; // Touch Point 1 and 2's Distance
    Vector3 pos;
    NextStagePanel nsp;

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount == 2) // Touch Point Count : over 2
        {
            if (Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position) < initTouchDist)
            {
                if (transform.localScale != new Vector3(0.5f, 0.5f, 1))
                {
                    transform.localScale = new Vector3(transform.localScale.x - 0.05f, transform.localScale.y - 0.05f, transform.localScale.z);
                }
            }
            initTouchDist = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
        }
        if (transform.localScale == new Vector3(0.5f, 0.5f, 1))
        {
            if (transform.localPosition.y > 2)
            {
                nsp = FindObjectOfType<NextStagePanel>();
                nsp.NextPanel();
            }
        }
    }
}


