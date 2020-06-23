using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public VideoPlayer vp;


    public void UsePauseMenu()
    {
            pauseMenu.SetActive(true);
            vp.Pause();
    }

    public void PauseMenuOff()
    {
            pauseMenu.SetActive(false);
            vp.Play();
    }

}
