using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrueDoor : MonoBehaviour
{
    [SerializeField] private GameObject pass;
    [SerializeField] private Button b;
    [SerializeField] private InputField input;
    EnterX en;

    private void Start()
    {
        pass.gameObject.SetActive(false);
        b.gameObject.SetActive(false);
        input.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //화면의 좌표계를 월드 좌표계로 전환해주는 함수

			RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                string obname = hit.collider.gameObject.name;
                //Debug.Log(obname);
                if(obname=="door03")
                {
                    pass.gameObject.SetActive(true);
                    b.gameObject.SetActive(true);
                    input.gameObject.SetActive(true);
                    en = FindObjectOfType<EnterX>();
                    en.enterButton();
                }
            }
        }
    }
}


     
