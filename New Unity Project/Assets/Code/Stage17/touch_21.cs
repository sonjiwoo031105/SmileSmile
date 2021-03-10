using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch_21 : MonoBehaviour
{
    Vector3 MousePosition;
    [SerializeField] private GameObject x;
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
        if (x.activeSelf == true) //1.5f초동안 같은 자리이면 안보이게 하기
        {
            GameTime -= Time.deltaTime;
            if ((int)GameTime == 0)
            {
                x.gameObject.SetActive(false);
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (-0.4 <= MousePosition.x && MousePosition.x <= 0 && -0.6 <= MousePosition.y && MousePosition.y <= -0.4)
            {
/*                Debug.Log(MousePosition);*/
                GameObject.Find("Main Camera").GetComponent<NextStagePanel>().NextPanel();
            }
            else
            {
                x.gameObject.SetActive(true);
                GameTime = 1.5f;
                c.setCount();
            }
        }
    }
}
