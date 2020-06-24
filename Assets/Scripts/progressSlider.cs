using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class progressSlider : MonoBehaviour
{
    public Image loadingBar;
    public VideoPlayer _player;

    // Start is called before the first frame update
    void Start()
    {
        
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
}
