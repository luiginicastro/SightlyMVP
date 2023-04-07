using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.Linq;
using TMPro;


public class videoPlayer360 : MonoBehaviour
{

    public RenderTexture videoSkyboxTemplate; // place your RT360Video texture in here
    public Material skyboxTemplate; // place your Skybox material in here
    public Material videoSkybox; // place your 360Material here
    
    [SerializeField] private GameObject structure;
    [SerializeField] private GameObject contentSlides;
    [SerializeField] private GameObject sessionEndedMenu;
    [SerializeField] private GameObject pauseMenu;

    public bool inSession; // this determines if the user is in a session so scripts can run

    public GameObject handTimer;
    public RigRotation _rigRot;
    
    [SerializeField] UnityEngine.Video.VideoPlayer _player; // the 360 videoplayer


    private void Start() 
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
        inSession = true;
        videoTransition();
    }

    private void videoTransition()
    {
        if (inSession == true)
        {
            structure.SetActive(false);
            contentSlides.SetActive(false);
            RenderSettings.skybox = videoSkybox;
            handTimer.SetActive(true);
        }
        
        else if (inSession == false)
        {
            structure.SetActive(true);
            contentSlides.SetActive(true);
            RenderSettings.skybox = skyboxTemplate;
            handTimer.SetActive(false);
        }
    }

    public void PauseVideo() // pauses the video for user
    {
        _player.Pause();
        handTimer.SetActive(false);
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
        _rigRot.origPos();
        handTimer.SetActive(false);
    }

    public void pauseMenuTriggered() // if the user is in a session they can pause the video
    {
        if (inSession)
        {
            PauseVideo();
            pauseMenu.SetActive(true);
        }
        
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp) // when the video ends it runs the script
    {
        sessionEndedMenu.SetActive(true);
    }

    public void OnVideoEnd() // this makes the session false, stops the video, resets the skybox, turns on the room and slides
    {
        inSession = false;
        StopVideo();
        RenderSettings.skybox = skyboxTemplate;
        ReleaseRenderTexture(); // this resets the texture for the Skybox after each video
        structure.SetActive(true);
        contentSlides.SetActive(true);
        pauseMenu.SetActive(false);
        _rigRot.origPos();
        handTimer.SetActive(false);
        sessionEndedMenu.SetActive(false);
    }

    public void ReleaseRenderTexture() // this is how it resets the texture for the skybox
    {
        RenderTexture rt = UnityEngine.RenderTexture.active;
        UnityEngine.RenderTexture.active = videoSkyboxTemplate;
        GL.Clear(true, true, Color.clear);
        UnityEngine.RenderTexture.active = rt;
        RenderSettings.skybox = skyboxTemplate;
    }
}
