using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusstar : MonoBehaviour
{
    [SerializeField] GameObject fry;
    private GameObject[] stars;

    // Start is called before the first frame update
    void Start()
    {
        stars = GameObject.FindGameObjectsWithTag("star");
        for (int i = 0; i < stars.Length; i++)
        {
            stars[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float fry_x = fry.gameObject.transform.position.x;
        float fry_y = fry.gameObject.transform.position.y;

        if(0.7<= fry_x && fry_x<=1.3 && 1.2<=fry_y && fry_y <= 1.8)
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].SetActive(true);
            }
            fry.SetActive(false);
        }
    }
}
