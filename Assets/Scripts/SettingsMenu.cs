using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsMenu; // this is the settingsmenu object
    public GameObject settingsToggleOn;
    public GameObject settingsToggleOff;
    public VideoPlayer vp;



    public void SettingsOn()
    {
        settingsMenu.SetActive(true); //this turns on the settings panel
        settingsToggleOn.SetActive(false);
        settingsToggleOff.SetActive(true);
        vp.Pause();
        vp.GetComponent<MeshRenderer>().enabled = false;

    }

    public void SettingsOff()
    {
        settingsMenu.SetActive(false); //this turns off the settings panel
        settingsToggleOn.SetActive(true);
        settingsToggleOff.SetActive(false);
        vp.Play();
        vp.GetComponent<MeshRenderer>().enabled = true;
    }
}
