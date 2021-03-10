using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public bool LeftMove = false;
    public bool RightMove = false;
    public bool UpMove = false;
    public bool DownMove = false;
    Vector3 pos, pos_camera;

    // Update is called once per frame
    void Update()
    {
        pos = this.gameObject.transform.position;
        if(2<=pos.x && pos.x<=2.2 && 1.5<=pos.y && pos.y <= 1.7)
        {
            GameObject.Find("Main Camera").GetComponent<NextStagePanel>().NextPanel();
        }
        else
        {
            if (LeftMove) { transform.Translate(Vector3.left * Time.deltaTime); }
            if (RightMove) { transform.Translate(Vector3.right * Time.deltaTime); }
            if (UpMove) { transform.Translate(Vector3.up * Time.deltaTime); }
            if (DownMove) { transform.Translate(Vector3.down * Time.deltaTime); }
        }

        //카메라 밖에 안나가기
        pos_camera = Camera.main.WorldToViewportPoint(transform.position);

        if (pos_camera.x < 0f) pos_camera.x = 0f;
        if (pos_camera.x > 1f) pos_camera.x = 1f;
        if (pos_camera.y < 0f) pos_camera.y = 0f;
        if (pos_camera.y > 1f) pos_camera.y = 1f;

        transform.position = Camera.main.ViewportToWorldPoint(pos_camera);
    }
}