using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class exit_sound : MonoBehaviour
{
    AudioSource audioSource;
    int divi = 0; // 플레이, 중지구분하기
    private float GameTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if(divi == 1)
        {
            GameTime -= Time.deltaTime;
            if ((int)GameTime == 0)
            {
                GameObject.Find("Main Camera").GetComponent<NextStagePanel>().NextPanel();
            }
        }
    }

    public void buttonClicked()
    {
        if (divi == 1) { audioSource.Stop();} //소리 한번끄면 다시 킬 수 없음
        else { audioSource.Play(); divi = 1; }
    }
}
