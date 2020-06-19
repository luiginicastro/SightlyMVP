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
    public GameObject _rigPosition;

    public VideoPlayer _videoPlayer;

    public void Start()
    {
        _videoPlayer = GameObject.FindGameObjectWithTag("360Camera").GetComponent<VideoPlayer>();
        _rigPosition = GameObject.FindGameObjectWithTag("XRRig");
    }

    public void Update()
    {
        _videoPlayer.loopPointReached += EndReached;
    }

    public void selectVideo()
    {
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

    private void RotateOrientation(float yRot)
    {
        _rigPosition.transform.eulerAngles = new Vector3(_rigPosition.transform.eulerAngles.x, yRot, _rigPosition.transform.eulerAngles.z);
    }
}
