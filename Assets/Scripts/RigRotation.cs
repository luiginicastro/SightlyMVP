using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigRotation : MonoBehaviour
{
    public GameObject _rigPosition;
    public Quaternion origRot;

    // Start is called before the first frame update
    void Start()
    {
        origRot = _rigPosition.transform.rotation;
    }

    public void origPos()
    {
        _rigPosition.transform.rotation = origRot;
    }
}
