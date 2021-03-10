using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour
{
    Count c = new Count();
    private void OnMouseDrag()
    {
        Vector3 mousePosition
        = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        //마우스 좌표를 스크린 투 월드로 바꾸고 이 객체의 위치로 설정해 준다.
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }
    private void OnMouseDown()
    {
        c.setCount();
        Debug.Log(c.getCount());
    }
}
