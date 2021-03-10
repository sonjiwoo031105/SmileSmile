using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterX : MonoBehaviour
{
    [SerializeField] private InputField input;
    [SerializeField] private string text1;
    [SerializeField] private GameObject x;
    private float GameTime = 1.5f;
    Count c = new Count();

    void Start()
    {
        x.gameObject.SetActive(false);
    }  

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
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("Stage"); // 씬 전환
            }
        }
    }

    public void enterButton()
    {
        if (input.text == text1)
        {
            GameObject.Find("Main Camera").GetComponent<NextStagePanel>().NextPanel();
        }
        else
        {
            c.setCount();
            input.SetTextWithoutNotify("");
            x.gameObject.SetActive(true);
            GameTime = 1.5f;
        }
    }
}
