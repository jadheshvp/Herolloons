using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SfxManager : MonoBehaviour
{

    [SerializeField] Image SfxOn;
    [SerializeField] Image SfOff;
    private bool muted = false;

    
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonicon();
        AudioListener.pause = muted;
    }

    public void OnButtonPress()
    {
        if(muted == false)
        {
            muted = true;
            AudioListener.pause = true;

        }
        else
        {
            muted = false;
            AudioListener.pause = false;

        }

        Save();
        UpdateButtonicon();
    }
    private void UpdateButtonicon()
    {
        if (muted == false)
        {
            SfxOn.enabled = true;
            SfOff.enabled = false;
        }
        else
        {
            SfxOn.enabled = false;
            SfOff.enabled = true;
        }

    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
