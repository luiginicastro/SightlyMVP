using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class buttonManager : MonoBehaviour
{
    public GameObject buttons; //this holds the continue, back, replay buttons
    public VideoPlayer vp; // this holds main video player
    public GameObject replay; // this holds replay button only

    public bool videoPlayed; //tells us if the user has already watched the video

    
    void Start() //this finds the objects we are using
    {
        vp = FindObjectOfType<VideoPlayer>();
        buttons = GameObject.Find("ButtonInteraction");
        replay = GameObject.Find("ReplayButton");
    }

    
    void Update()
    {
        buttonController();
    }

    public void buttonController()
    {
        RevealButtons();
        RevealReplay();
        VideoPlayed();

        vp.loopPointReached += buttonsON; // when video ends reveal buttons for users
    }

    private void VideoPlayed() // if the video finished then buttons are revealed
    {
        if (videoPlayed == true)
        {
            buttons.SetActive(true);
        }
        else if (videoPlayed == false)
        {
            buttons.SetActive(false);
        }
    }

    private void RevealReplay() // if the video finishes then reveal replay button
    {
        if (vp.isPlaying)
        {
            replay.SetActive(false);
        }
        else 
        {
            replay.SetActive(true);
        }
    }

    private void RevealButtons() // while the video is playing you can't see buttons unless you finished the video already
    {
        if (vp.isPlaying)
        {
            buttons.SetActive(false);
        }
        else
        {
            buttons.SetActive(true);
        }
    }

    public void buttonsON(VideoPlayer vp) // if you finished the video then buttons stay on for that slide
    {
        videoPlayed = true;

        if (vp.isPlaying && videoPlayed == true)
        {
            buttons.SetActive(true);
        }
    }

    public void replayVideo() // button that lets user replay the video on that current slide
    {
        vp.Play();
    }
}
