using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shake : MonoBehaviour
{
    public GameObject bosuck;
    NextStagePanel nsp;

    Vector3 acclerationDir;

    void Update()
    {
        acclerationDir = Input.acceleration;

        if(acclerationDir.sqrMagnitude >= 5f)
        {
            bosuck.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            nsp = FindObjectOfType<NextStagePanel>();
            nsp.NextPanel();
        }
    }

    public void ResetScene()
    {
        SceneManager.LoadScene("game23");
    }
}
