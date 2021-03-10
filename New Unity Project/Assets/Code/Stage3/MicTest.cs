using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MicTest : MonoBehaviour
{
    public AudioClip aud;
    int sampleRate = 44100;
    private float[] samples;
    public float rmsValue;
    public float modulate;
    public int resultValue;
    public int cutValue;
    public Text txt;
    NextStagePanel nsp;

    private void Start()
    {
        samples = new float[sampleRate];
        aud = Microphone.Start(Microphone.devices[0].ToString(), true, 1, sampleRate);
    }

    private void Update()
    {
        aud.GetData(samples, 0);
        float sum = 0;
        for(int i = 0; i < samples.Length; i++)
        {
            sum += samples[i] * samples[i];
        }
        rmsValue = Mathf.Sqrt(sum / samples.Length);
        rmsValue = rmsValue * modulate;
        rmsValue = Mathf.Clamp(rmsValue, 0, 500);
        resultValue = Mathf.RoundToInt(rmsValue);

        string str = resultValue.ToString();
        txt.text = str;
        if (resultValue >= 300 && resultValue <= 499)
        {
            txt.text = "조금만 더 힘내세요!";
        }else if(resultValue >= 500)
        {
            nsp = FindObjectOfType<NextStagePanel>();
            nsp.NextPanel();
        }
    }
}
