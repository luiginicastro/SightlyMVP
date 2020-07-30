using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class progressSlider : MonoBehaviour
{
    public Image loadingBar;
    public VideoPlayer _player;

    public GameObject userTimerUI; // the timer for when the user can speak
    public float startUserTime; // when the timer will appear for users
    public float endUserTime; // when the timer will end for users

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("userTimer", 5);
    }

    private void Awake()
    {
        loadingBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (_player.frameCount > 0)
        {
            loadingBar.fillAmount = (float)_player.frame / (float)_player.frameCount;
        }
    }

    public void userTimer()
    {
            userTimerUI.SetActive(true);
            Debug.Log("hi");

        //if (loadingBar.fillAmount == endUserTime)
        //{
        //    userTimerUI.SetActive(false);
        //}

    }
}
