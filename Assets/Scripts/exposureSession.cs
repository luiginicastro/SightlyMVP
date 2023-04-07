using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using A11YTK;
using Unity.Services.Analytics;
using Unity.Services.Core;
using Unity.Services.Core.Environments;
using System;

public class exposureSession : MonoBehaviour
{
    public string name;
    public GameObject currentSession;
    public VideoClip exposureClip;
    public GameObject completedSession;
    public float videoRotation;
    public GameObject _rigPosition;
    public Quaternion origRot;
    public GameObject XRRig;
    public GameObject Camera;

    public TextAsset srtFile;

    public VideoPlayer _videoPlayer;
    public string environment = "production";
    public async void Start()
    {
        _videoPlayer = Camera.GetComponent<VideoPlayer>();
        _rigPosition = XRRig;

        try
        {
            var options = new InitializationOptions().SetEnvironmentName(environment);

            await UnityServices.InitializeAsync(options);
        }
        catch (Exception exception)
        {
            // An error occurred during services initialization.
        }
    }

    public void Update()
    { 
        _videoPlayer.loopPointReached += EndReached;
    }

    public void selectVideo()
    {
        _videoPlayer.GetComponent<SubtitleVideoPlayerController>().subtitleTextAsset = srtFile;
        _videoPlayer.clip = exposureClip;
        RotateOrientation(videoRotation);
    }

    public void OnVideoEnd() // this makes the session false, stops the video, resets the skybox, turns on the room and slides
    {
        completedSession.SetActive(true);
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp) // when the video ends it runs the script
    {
        OnVideoEnd();
        
    }

    public void RotateOrientation(float yRot)
    {
        _rigPosition.transform.eulerAngles = new Vector3(_rigPosition.transform.eulerAngles.x, yRot, _rigPosition.transform.eulerAngles.z);
    }

    

    public void SessionStarted()
    {
       AnalyticsService.Instance.CustomData("sessionStarted", new Dictionary<string, object>
        {
            {"Session", name}
        });
        Events.Flush();

        currentSession.name = name;
    }

    public void SessionEnded()
    {
        AnalyticsService.Instance.CustomData("sessionFinished", new Dictionary<string, object>
        {
            {"Session", name}
        });
        Events.Flush();
    }

}
