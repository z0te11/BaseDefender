using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WavePanel : MonoBehaviour
{
    [SerializeField] private Text textWave;
    private void OnEnable()
    {
        WaveController.onWaveStart += ShowWaveText;
    }

    private void OnDisable()
    {
        WaveController.onWaveStart -= ShowWaveText;
    }
    private void ShowWaveText(int numberWave)
    {
        textWave.text = numberWave.ToString();
    }
}
