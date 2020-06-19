using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.Linq;
using TMPro;


public class videoPlayer360 : MonoBehaviour
{

    bool videoCompleted = false;

    public GameObject _positionHandle;

    public RenderTexture videoSkyboxTemplate; // place your RT360Video texture in here
    public Material skyboxTemplate; // place your Skybox material in here
    public Material videoSkybox; // place your 360Material here
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject structure;
    [SerializeField] private GameObject contentSlides;
    [SerializeField] private GameObject pauseMenu;
    public bool InSession;

    public exposureSession _exposureSession;

    [SerializeField] UnityEngine.Video.VideoPlayer _player; // the 360 videoplayer

    
    private void Update() //COME BACK TO FIX THIS SO THAT THIS FUNCTION WORKS WHEN VIDEO ENDS
    {
        _player.loopPointReached += EndReached;
        
    }

    public void DelayedPlay(float secondsDelay)
    {
        StartCoroutine(WaitToPlay(secondsDelay));
    }

    IEnumerator WaitToPlay(float secondsDelay) // this gives a delay before the video starts
    {
        yield return new WaitForSeconds(secondsDelay);
        PlayVideo();
    }

    public void PlayVideo() // this plays the video player
    { 
        _player.Play();
        pauseMenu.SetActive(false);
        InSession = true;
        videoTransition();
    }

    private void videoTransition()
    {
        if (InSession == true)
        {
            structure.SetActive(false);
            contentSlides.SetActive(false);
            RenderSettings.skybox = videoSkybox;
        }
        
        else if (InSession == false)
        {
            structure.SetActive(true);
            contentSlides.SetActive(true);
            RenderSettings.skybox = skyboxTemplate;
        }
    }

    public void PauseVideo() // pauses the video for user
    {
        _player.Pause();
    }

    public void ResetVideo() // resets the video
    {
        _player.frame = 0;
    }

    public void StopVideo() // video stops and the clip gets cleared for new one to start
    {
        _player.Stop();
        _player.frame = 0;
        _player.clip = null;
        _exposureSession._rigPosition.transform.eulerAngles = new Vector3(_exposureSession._rigPosition.transform.eulerAngles.x, 90, _exposureSession._rigPosition.transform.eulerAngles.z);
    }

    public void pauseMenuTriggered()
    {
        if (InSession)
        {
            PauseVideo();
            pauseMenu.SetActive(true);
        }
        
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp) // when the video ends it runs the script
    {
        OnVideoEnd();
    }

    private void OnVideoEnd() // this makes the session false, stops the video, resets the skybox, turns on the room and slides
    {
        InSession = false;
        StopVideo();
        RenderSettings.skybox = skyboxTemplate;
        ReleaseRenderTexture(); // this resets the texture for the Skybox after each video
        structure.SetActive(true);
        contentSlides.SetActive(true);
        pauseMenu.SetActive(false);
        _exposureSession._rigPosition.transform.eulerAngles = new Vector3(_exposureSession._rigPosition.transform.eulerAngles.x, 90, _exposureSession._rigPosition.transform.eulerAngles.z);
    }

    public void ReleaseRenderTexture() // this is how it resets the texture for the skybox
    {
        RenderTexture rt = UnityEngine.RenderTexture.active;
        UnityEngine.RenderTexture.active = videoSkyboxTemplate;
        GL.Clear(true, true, Color.clear);
        UnityEngine.RenderTexture.active = rt;
        RenderSettings.skybox = skyboxTemplate;
    }

    public void ExitVideoTriggered() //if the user chooses to leave video early it makes the session false, stops the video, resets the skybox, turns on the room and slides
    {
        InSession = false;
        StopVideo();
        RenderSettings.skybox = skyboxTemplate;
        ReleaseRenderTexture(); // this resets the texture for the Skybox after each video
        structure.SetActive(true);
        contentSlides.SetActive(true);
        pauseMenu.SetActive(false);
        _exposureSession._rigPosition.transform.eulerAngles = new Vector3(_exposureSession._rigPosition.transform.eulerAngles.x, 90, _exposureSession._rigPosition.transform.eulerAngles.z);
    }

    
}
