using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchManager : MonoBehaviour
{
    private float initTouchDist; // Touch Point 1 and 2's Distance
    Vector3 pos;

    // Update is called once per frame
    private void Update()
    {
        if (Input.touchCount == 2) // Touch Point Count : over 2
        {       
            if (Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position) < initTouchDist)
            {
                if (transform.localScale != new Vector3(0.5f, 0.5f, 1))
                {
                    transform.localScale = new Vector3(transform.localScale.x - 0.05f, transform.localScale.y - 0.05f, transform.localScale.z);
                }
            }
            initTouchDist = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
        }

        pos = this.gameObject.transform.position;
        if (transform.localScale == new Vector3(0.5f, 0.5f, 1) &&
            0.5 <= pos.x && pos.x <= 0.71 && -1.75 <= pos.y && pos.y <= -1.45)
        {
            GameObject.Find("Main Camera").GetComponent<NextStagePanel>().NextPanel();
        }
    }
}

