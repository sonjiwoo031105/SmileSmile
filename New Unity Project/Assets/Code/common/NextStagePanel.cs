using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextStagePanel : MonoBehaviour
{
    [SerializeField] private GameObject nextpanel;
    [SerializeField] private string sceneName;

    // Start is called before the first frame update
    private void Start()
    {
        nextpanel.gameObject.SetActive(false); //판넬 안보이기
    }

    public void NextPanel()
    {
        nextpanel.gameObject.SetActive(true); //판넬 보이기
    }
    public void ButtonClicked()
    {   
        SceneManager.LoadScene(sceneName); // 씬 전환
    }
    public bool getPanel() {
        return nextpanel.gameObject.activeSelf;
    }
}
