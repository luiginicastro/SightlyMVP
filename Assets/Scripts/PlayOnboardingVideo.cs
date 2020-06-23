using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayOnboardingVideo : MonoBehaviour
{
    public VideoPlayer vp;
    public GameObject _player;
    public VideoClip onboardingClip;
    public GameObject content;

    private void Update() // when the video ends it calls the endReache method
    {
        vp.loopPointReached += EndReached;
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp) // when the video ends it runs the script
    {
        endOnboarding();
    }

    public void StartOnboarding() // starts onboarding video
    {
        _player.SetActive(true);
        content.SetActive(false);
        vp.clip = onboardingClip;
    }

    public void endOnboarding() // ends onboarding video
    {
        _player.SetActive(false);
        content.SetActive(true);
        vp.Stop();
    }


}
