using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ViciousCycleReference", menuName = "ViciousCycleReference")]
public class ViciousCycleReference : ScriptableObject
{
    
    public Dictionary<string, List<string>> cycles = new Dictionary<string, List<string>>(); //Dictionary needs a key and value. The key is how you reference the unique value 

    public void Save()
    {

        // save dictionary to key

    }

    public void Load()
    {

        // populate dictionary from key

    }

}
