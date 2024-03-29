﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using TMPro;

public class videoProgress : MonoBehaviour
{
    [Header("Pause Menu Timer")]
    public TextMeshProUGUI timeElapsedMinutes;
    public TextMeshProUGUI timeElapsedSeconds;
    public TextMeshProUGUI totalTimeMinutes;
    public TextMeshProUGUI totalTimeSeconds;

    [Header("Hand Timer")]
    public TextMeshProUGUI handTimeElapsedMinutes;
    public TextMeshProUGUI handTimeElapsedSeconds;
    public TextMeshProUGUI handTotalTimeMinutes;
    public TextMeshProUGUI handTotalTimeSeconds;

    public VideoPlayer _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<VideoPlayer>();
    }

    private void Update()
    {
        if (_player.isPlaying)
        {
            SetTimeElapsedUI();
            SetTotalTimeUI();
        }
        
    }

    void SetTimeElapsedUI()
    {
        string minutes = Mathf.Floor((int)_player.time / 60).ToString("00");
        string seconds = ((int)_player.time % 60).ToString("00");

        timeElapsedMinutes.text = minutes;
        timeElapsedSeconds.text = seconds;

        handTimeElapsedMinutes.text = minutes;
        handTimeElapsedSeconds.text = seconds;
    }

    void SetTotalTimeUI()
    {
        string minutes = Mathf.Floor((int)_player.clip.length / 60).ToString("00");
        string seconds = ((int)_player.clip.length % 60).ToString("00");

        totalTimeMinutes.text = minutes;
        totalTimeSeconds.text = seconds;

        handTotalTimeMinutes.text = minutes;
        handTotalTimeSeconds.text = seconds;
    }

}
