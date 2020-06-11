using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class beginSession : MonoBehaviour
{
    public GameObject intro;
    public GameObject quadPlayer;
    public GameObject[] Session; // the current session you are on
    public GameObject SessionMenu; // the menu that lets you pick what session to start
    public GameObject SessionsParent; // the empty gameObject that holds all the sessions
    public VideoPlayer vp;

    private NextPanel _nextPanel;

    // Start is called before the first frame update
    void Start()
    {
        intro.SetActive(true);
        quadPlayer.SetActive(false);
    }

    public void startSession1() // reveals this session
    {
        intro.SetActive(false);
        quadPlayer.SetActive(true);
        Session[0].SetActive(true);
        vp.Play();
        SessionMenu.SetActive(false);
        SessionsParent.SetActive(true);
    }

    public void startSession2() // reveals this session
    {
        intro.SetActive(false);
        quadPlayer.SetActive(true);
        Session[1].SetActive(true);
        vp.Play();
        SessionMenu.SetActive(false);
        SessionsParent.SetActive(true);
    }

    public void startSession3() // reveals this session
    {
        intro.SetActive(false);
        quadPlayer.SetActive(true);
        Session[2].SetActive(true);
        vp.Play();
        SessionMenu.SetActive(false);
        SessionsParent.SetActive(true);
    }

    public void startSession4() // reveals this session
    {
        intro.SetActive(false);
        quadPlayer.SetActive(true);
        Session[3].SetActive(true);
        vp.Play();
        SessionMenu.SetActive(false);
        SessionsParent.SetActive(true);
    }

    public void startSession5() // reveals this session
    {
        intro.SetActive(false);
        quadPlayer.SetActive(true);
        Session[4].SetActive(true);
        vp.Play();
        SessionMenu.SetActive(false);
        SessionsParent.SetActive(true);
    }

    public void startSession6() // reveals this session
    {
        intro.SetActive(false);
        quadPlayer.SetActive(true);
        Session[5].SetActive(true);
        vp.Play();
        SessionMenu.SetActive(false);
        SessionsParent.SetActive(true);
    }

    public void startSession7() // reveals this session
    {
        intro.SetActive(false);
        quadPlayer.SetActive(true);
        Session[6].SetActive(true);
        vp.Play();
        SessionMenu.SetActive(false);
        SessionsParent.SetActive(true);
    }

    public void startSession8() // reveals this session
    {
        intro.SetActive(false);
        quadPlayer.SetActive(true);
        Session[7].SetActive(true);
        vp.Play();
        SessionMenu.SetActive(false);
        SessionsParent.SetActive(true);
    }
}
