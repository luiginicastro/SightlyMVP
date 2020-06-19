using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class exposureSession : MonoBehaviour
{
        public string name;
        public VideoClip exposureClip;
        public GameObject completedSession;
        public float videoRotation;

   public VideoPlayer _videoPlayer;

    public void Update()
    {
        _videoPlayer.loopPointReached += EndReached;
    }

    public void selectVideo()
    {
        _videoPlayer.clip = exposureClip;
    }

    public void OnVideoEnd() // this makes the session false, stops the video, resets the skybox, turns on the room and slides
    {
        completedSession.SetActive(true);
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp) // when the video ends it runs the script
    {
        OnVideoEnd();
    }
}
