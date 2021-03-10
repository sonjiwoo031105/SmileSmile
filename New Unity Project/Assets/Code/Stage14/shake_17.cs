using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake_17 : MonoBehaviour
{
    Vector3 acclerationDir;
    [SerializeField] private GameObject smile;
    private GameObject[] leaves;
    private float GameTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        leaves = GameObject.FindGameObjectsWithTag("leaf");
        smile.gameObject.SetActive(false);
        for(int i=0; i<leaves.Length; i++)
        {
            leaves[i].SetActive(false);
        }  
    }

    // Update is called once per frame
    void Update()
    {
        acclerationDir = Input.acceleration;
        if (acclerationDir.sqrMagnitude >= 10f)
        {
            smile.gameObject.SetActive(true);
            for (int i = 0; i < leaves.Length; i++)
            {
                leaves[i].SetActive(true);
            }
        }
        if(smile.activeSelf == true)
        {
            GameTime -= Time.deltaTime;
            if ((int)GameTime == 0)
            {
                GameObject.Find("Main Camera").GetComponent<NextStagePanel>().NextPanel();
            }
        }        
    }
}
