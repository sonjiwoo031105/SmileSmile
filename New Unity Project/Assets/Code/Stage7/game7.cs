using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game7 : MonoBehaviour
{
    [SerializeField] private GameObject hint;
    [SerializeField] private GameObject nextStage;
    [SerializeField] private GameObject people;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hint.gameObject.activeSelf == true || nextStage.gameObject.activeSelf == true)
        {
            people.gameObject.SetActive(false);
        }
        else
        {
            people.gameObject.SetActive(true);
        }
    }
}
