using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public string stringToEdit = "HelloWorld!";

    private void OnGUI()
    {
        stringToEdit = GUILayout.TextField(stringToEdit, 25);
    }
}
