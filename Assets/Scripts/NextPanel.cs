using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Michsky.UI.ModernUIPack;
using UnityEngine.Video;

public class NextPanel : MonoBehaviour
{
    
    [SerializeField] public VideoPlayer vp;

    public GameObject quadPlayer;

    public GameObject currentSession;

    public GameObject[] slides; //each slide you want to have
    [SerializeField] public VideoClip[] slideVideo; // the video clips being used

    [SerializeField] ProgressBar _progressBar;
    public float progressIncrease;

    public int _currentSlide = -1; // starts the array at -1 so when you hit continue to goes to the next slide

    void Start() // this is a for loop that adds 1 to slides so that it can move forward in the array and keep slides off when we aren't on them
    {

        var currentActiveSlideIndex = slides.ToList().FindIndex(slide => slide.activeSelf); //look for the index in the slidesarray for the first active slide

        for (int i = 0; i < slides.Length; i++)
        {
            slides[i].SetActive(false);
        }

        if (currentActiveSlideIndex != -1)
        {
            currentSlide(currentActiveSlideIndex);
        } else
        {
            currentSlide(0);
        }
    }

    public void currentSlide(int currentSlide) // an if statement saying if _currentSlide and currentSlide are the same then show that slide
    {
        if (_currentSlide >= 0)
            slides[_currentSlide].SetActive(false);

        _currentSlide = currentSlide;
        slides[currentSlide].SetActive(true);
    }

    public void NextSlide() // when this activates it incresases _currentSlide by one so we can move forward on slides
    {

        int nextSlide = (_currentSlide + 1) % slides.Length;
        currentSlide(nextSlide);
        _progressBar.currentPercent = _currentSlide * progressIncrease;
        
    }

    public void BackSlide() // when this activates it decresases _currentSlide by one so we can move back on slides
    {
        int nextSlide = (_currentSlide - 1) % slides.Length;
        currentSlide(nextSlide);
        _progressBar.currentPercent = _progressBar.currentPercent - progressIncrease;
        vp.clip = slideVideo[_currentSlide];
        vp.Play();
    }
   
    public void PlayVideo() // this plays the video based on the slide you are on
    {
        vp.clip = slideVideo[_currentSlide];
        vp.Play();
    }

    public void CloseCurrentSession() //this will close the session you are currently on
    {
        currentSession.SetActive(false);
        vp.Stop();
        quadPlayer.SetActive(false);
    }

}
