using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Analytics;
using Unity.Services.Core;
using Unity.Services.Core.Environments;
using System;

public class sessionTracker : MonoBehaviour
{
    public string sessionName;
    public GameObject currentSession;

    public void SessionStarted()
    {
        sessionName = currentSession.name;

        AnalyticsService.Instance.CustomData("sessionStarted", new Dictionary<string, object>
        {
            {"Session", sessionName}
        });
        Events.Flush();
        Debug.Log("session " + name + " started");
    }

    public void SessionEnded()
    {
        sessionName = currentSession.name;
        AnalyticsService.Instance.CustomData("sessionFinished", new Dictionary<string, object>
        {
            {"Session", sessionName}
        });
        Events.Flush();
    }

    public void GoodSession()
    {
        sessionName = currentSession.name;
        AnalyticsService.Instance.CustomData("goodSession", new Dictionary<string, object>
        {
            {"Session", sessionName}
        });
        Events.Flush();
    }

    public void BadSession()
    {
        sessionName = currentSession.name;
        AnalyticsService.Instance.CustomData("badSession", new Dictionary<string, object>
        {
            {"Session", sessionName}
        });
        Events.Flush();
    }
}
