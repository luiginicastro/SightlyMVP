using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject SessionsMenu;
    public GameObject Profile;
    public GameObject Exposure;
    public GameObject Sessions;
    public GameObject Settings;

    public void SessionMenu() // reveals Session Menu
    {
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(true);
    }
    public void ProfileMenu() // reveals Profile Menu
    {
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(true);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
    }
    public void ExposureMenu() // reveals Exposure Menu
    {
        MainMenu.SetActive(false);
        Exposure.SetActive(true);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
    }

    public void Menu()  // reveals Main Menu
    {
        MainMenu.SetActive(true);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        Settings.SetActive(false);
    }

}
