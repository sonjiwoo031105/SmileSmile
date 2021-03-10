using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touch_x : MonoBehaviour
{
    Vector3 MousePosition;
    [SerializeField] private GameObject x;
    Vector3 temp_pos;
    private float GameTime = 1.5f;
    Count c = new Count();

    // Start is called before the first frame update
    void Start()
    {
        x.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {        
        if(temp_pos == x.transform.position) //1.5f초동안 같은 자리이면 안보이게 하기
        {
            GameTime -= Time.deltaTime;
            if((int)GameTime == 0)
            {
                x.gameObject.SetActive(false);
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (-2 <= MousePosition.x && MousePosition.x <= 2 && -2 <= MousePosition.y && MousePosition.y <= 2)
            {
                x.gameObject.SetActive(true);
                x.transform.position = new Vector3(MousePosition.x, MousePosition.y, 0);
                temp_pos = x.transform.position;
                GameTime = 1.5f;
                c.setCount();
            }
            else if(!(1.7<= MousePosition.x && MousePosition.x <= 2.2 && 4.1<= MousePosition.y && MousePosition.y <= 4.4))
            {
                GameObject.Find("Main Camera").GetComponent<NextStagePanel>().NextPanel();
            }
        }
    }
}
