using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SettingsMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public VideoPlayer vp;


    public void PauseMenu()
    {
        pauseMenu.SetActive(true);
        vp.Pause();
    }
    
}
