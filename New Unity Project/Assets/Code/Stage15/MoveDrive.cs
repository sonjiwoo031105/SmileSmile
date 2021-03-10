using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDrive : MonoBehaviour
{
    private GameObject drive;
    NextStagePanel nsp;

    private void OnMouseDrag()
    {
        Vector3 mousePosition
     = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        //마우스 좌표를 스크린 투 월드로 바꾸고 이 객체의 위치로 설정해 준다.
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

        if (this.transform.position.x >= -1.8 && this.transform.position.x <= -1.7 &&
            this.transform.position.y >= -1.7 && this.transform.position.y <= -1.5)
        {
            nsp = FindObjectOfType<NextStagePanel>();
            nsp.NextPanel();
        }
    }
}
