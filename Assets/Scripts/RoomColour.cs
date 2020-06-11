using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomColour : MonoBehaviour
{
    public GameObject[] structure;
    public Material[] mats;

    

    public void blueRoom()
    {
        for (var i = 0; i < structure.Length; i += 1)
        {
            structure[i].GetComponent<MeshRenderer>().material = mats[0];
        }
    }

    public void greenRoom()
    {
        for (var i = 0; i < structure.Length; i += 1)
        {
            structure[i].GetComponent<MeshRenderer>().material = mats[1];
        }
    }

    public void yellowRoom()
    {
        for (var i = 0; i < structure.Length; i += 1)
        {
            structure[i].GetComponent<MeshRenderer>().material = mats[2];
        }
    }

    public void redRoom()
    {
        for (var i = 0; i < structure.Length; i += 1)
        {
            structure[i].GetComponent<MeshRenderer>().material = mats[3];
        }
    }
}
