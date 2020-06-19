using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [Header("Main Menus")]
    public GameObject LogIn;
    public GameObject SignUp;
    public GameObject MainMenu;
    public GameObject SessionsMenu;
    public GameObject Profile;
    public GameObject Exposure;
    public GameObject Sessions;
    public GameObject Settings;

    [Header("Session Sub-menus")]
    public GameObject interviews;
    public GameObject publicSpeaking;
    public GameObject socialGatherings;
    public GameObject criticism;
    public GameObject introductions;
    public GameObject beingTeased;
    public GameObject session7;

    [Header("Other")]
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

        interviews.SetActive(false);
        publicSpeaking.SetActive(false);
        socialGatherings.SetActive(false);
        criticism.SetActive(false);
        introductions.SetActive(false);
        beingTeased.SetActive(false);
        session7.SetActive(false);
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

        interviews.SetActive(false);
        publicSpeaking.SetActive(false);
        socialGatherings.SetActive(false);
        criticism.SetActive(false);
        introductions.SetActive(false);
        beingTeased.SetActive(false);
        session7.SetActive(false);
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

        interviews.SetActive(false);
        publicSpeaking.SetActive(false);
        socialGatherings.SetActive(false);
        criticism.SetActive(false);
        introductions.SetActive(false);
        beingTeased.SetActive(false);
        session7.SetActive(false);
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

        interviews.SetActive(false);
        publicSpeaking.SetActive(false);
        socialGatherings.SetActive(false);
        criticism.SetActive(false);
        introductions.SetActive(false);
        beingTeased.SetActive(false);
        session7.SetActive(false);
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

        interviews.SetActive(false);
        publicSpeaking.SetActive(false);
        socialGatherings.SetActive(false);
        criticism.SetActive(false);
        introductions.SetActive(false);
        beingTeased.SetActive(false);
        session7.SetActive(false);
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

        interviews.SetActive(false);
        publicSpeaking.SetActive(false);
        socialGatherings.SetActive(false);
        criticism.SetActive(false);
        introductions.SetActive(false);
        beingTeased.SetActive(false);
        session7.SetActive(false);
    }



    public void InterviewsLevels()  // reveals...
    {
        interviews.SetActive(true);
        publicSpeaking.SetActive(false);
        socialGatherings.SetActive(false);
        criticism.SetActive(false);
        introductions.SetActive(false);
        beingTeased.SetActive(false);
        session7.SetActive(false);

        LogIn.SetActive(false);
        SignUp.SetActive(false);
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        Settings.SetActive(false);
        SettingsButton.SetActive(false);
    }
    public void PublicSpeakingLevels()  // reveals...
    {
        interviews.SetActive(false);
        publicSpeaking.SetActive(true);
        socialGatherings.SetActive(false);
        criticism.SetActive(false);
        introductions.SetActive(false);
        beingTeased.SetActive(false);
        session7.SetActive(false);

        LogIn.SetActive(false);
        SignUp.SetActive(false);
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        Settings.SetActive(false);
        SettingsButton.SetActive(false);
    }
    public void SocialGatheringsLevels()  // reveals...
    {
        interviews.SetActive(false);
        publicSpeaking.SetActive(false);
        socialGatherings.SetActive(true);
        criticism.SetActive(false);
        introductions.SetActive(false);
        beingTeased.SetActive(false);
        session7.SetActive(false);

        LogIn.SetActive(false);
        SignUp.SetActive(false);
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        Settings.SetActive(false);
        SettingsButton.SetActive(false);
    }
    public void CriticismLevels()  // reveals...
    {
        interviews.SetActive(false);
        publicSpeaking.SetActive(false);
        socialGatherings.SetActive(false);
        criticism.SetActive(true);
        introductions.SetActive(false);
        beingTeased.SetActive(false);
        session7.SetActive(false);

        LogIn.SetActive(false);
        SignUp.SetActive(false);
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        Settings.SetActive(false);
        SettingsButton.SetActive(false);
    }
    public void IntroductionsLevels()  // reveals...
    {
        interviews.SetActive(false);
        publicSpeaking.SetActive(false);
        socialGatherings.SetActive(false);
        criticism.SetActive(false);
        introductions.SetActive(true);
        beingTeased.SetActive(false);
        session7.SetActive(false);

        LogIn.SetActive(false);
        SignUp.SetActive(false);
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        Settings.SetActive(false);
        SettingsButton.SetActive(false);
    }
    public void BeingTeasedLevels()  // reveals...
    {
        interviews.SetActive(false);
        publicSpeaking.SetActive(false);
        socialGatherings.SetActive(false);
        criticism.SetActive(false);
        introductions.SetActive(false);
        beingTeased.SetActive(true);
        session7.SetActive(false);

        LogIn.SetActive(false);
        SignUp.SetActive(false);
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        Settings.SetActive(false);
        SettingsButton.SetActive(false);
    }
    public void Session7Levels()  // reveals...
    {
        interviews.SetActive(false);
        publicSpeaking.SetActive(false);
        socialGatherings.SetActive(false);
        criticism.SetActive(false);
        introductions.SetActive(false);
        beingTeased.SetActive(false);
        session7.SetActive(true);

        LogIn.SetActive(false);
        SignUp.SetActive(false);
        MainMenu.SetActive(false);
        Exposure.SetActive(false);
        Profile.SetActive(false);
        Sessions.SetActive(false);
        SessionsMenu.SetActive(false);
        Settings.SetActive(false);
        SettingsButton.SetActive(false);
    }
}
