using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveman : MonoBehaviour
{
    private GameObject man;
    [SerializeField] private GameObject coin;
    NextStagePanel nsp;

    private void Start()
    {
        coin.gameObject.SetActive(false); 
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition
     = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        //마우스 좌표를 스크린 투 월드로 바꾸고 이 객체의 위치로 설정해 준다.
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

        if (this.transform.position.x >= 1.6 && this.transform.position.x <= 2.5 &&
            this.transform.position.y >= -3.5 && this.transform.position.y <= -3.1)
        {
             coin.gameObject.SetActive(true); 
        }
    }
   
    public void CoinClick()
    {
        nsp = FindObjectOfType<NextStagePanel>();
        nsp.NextPanel();
    }
}
