using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ApplicationNumber : MonoBehaviour
{
    public TextMeshProUGUI versionText;

    void OnEnable()
    {
        versionText.text = "Version Number: " + Application.version;
    }
}
