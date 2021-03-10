using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Button button;
    SpriteRenderer render;

    Count c = new Count();
    private float GameTime = 10f;

    private void Start()
    {
        panel.gameObject.SetActive(false);
        render = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if((int)GameTime > 0 && c.getCount() == 0) GameTime -= Time.deltaTime;
        if (c.getCount() >= 3 || (int)GameTime == 0)
        {
            render.color = new Color(1, 1, 1, 1);
        }
    }

    private void OnMouseDown()
    {
        if(c.getCount() >= 3 || (int)GameTime == 0)
        {
            if (GameObject.Find("Main Camera").GetComponent<NextStagePanel>().getPanel() == false)
            {
                panel.gameObject.SetActive(true);
            }
            button.onClick.AddListener(ButtonClicked);
        }
        
    }
    void ButtonClicked()
    {
        panel.gameObject.SetActive(false);
    }
}
