using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject LogIn;
    public GameObject SignUp;
    public GameObject MainMenu;
    public GameObject SessionsMenu;
    public GameObject Profile;
    public GameObject Exposure;
    public GameObject Sessions;
    public GameObject Settings;

    public GameObject SettingsButton;

    public void SessionMenu() // reveals Session Menu
    {
        LogIn.SetActive(false);
        SignUp.SetActive(false);
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(true);
        SettingsButton.SetActive(true);
    }
    public void ProfileMenu() // reveals Profile Menu
    {
        LogIn.SetActive(false);
        SignUp.SetActive(false);
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(true);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        SettingsButton.SetActive(true);
    }
    public void ExposureMenu() // reveals Exposure Menu
    {
        LogIn.SetActive(false);
        SignUp.SetActive(false);
        MainMenu.SetActive(false);
        Exposure.SetActive(true);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        SettingsButton.SetActive(true);
    }

    public void Menu()  // reveals Main Menu
    {
        LogIn.SetActive(false);
        SignUp.SetActive(false);
        MainMenu.SetActive(true);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        Settings.SetActive(false);
        SettingsButton.SetActive(true);
    }

    public void LogInMenu()  // reveals Log In Menu
    {
        LogIn.SetActive(true);
        SignUp.SetActive(false);
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        Settings.SetActive(false);
        SettingsButton.SetActive(false);
    }
    public void SignUpMenu()  // reveals Sign Up Menu
    {
        LogIn.SetActive(false);
        SignUp.SetActive(true);
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        Settings.SetActive(false);
        SettingsButton.SetActive(false);
    }

}
