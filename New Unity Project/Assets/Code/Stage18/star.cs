using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class star : MonoBehaviour
{
    end a = new end();
    public void clicked(GameObject pos)
    {
        pos.transform.localPosition = new Vector2(-104, 216);
        a.setCount();
        Debug.Log(a.getCount());

        if(a.getCount() == 5)
        {
            GameObject.Find("Main Camera").GetComponent<NextStagePanel>().NextPanel();
        }        
    }
}
class end
{
    private int count = 0;

    public int getCount() { return count; }
    public void setCount() { count += 1; }
}
