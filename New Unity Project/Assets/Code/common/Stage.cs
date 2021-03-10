using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Stage : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void ButtonClicked()
    {
        SceneManager.LoadScene(sceneName); // 씬 전환
    }
}
