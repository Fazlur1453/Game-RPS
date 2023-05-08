using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MuteAudio : MonoBehaviour
{
    [SerializeField] Toggle muteToggle;

    void Awake()
    {
        muteToggle.isOn = false;
        muteToggle.onValueChanged.AddListener(SetToggleVolume);
    }
    void SetToggleVolume(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
