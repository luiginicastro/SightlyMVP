using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class ViciousCycleSpawn : MonoBehaviour
{
    [SerializeField] ViciousCycleReference viciousCycle; // calls the ViciousCyclereference script

    [SerializeField] TextMeshProUGUI[] _thoughtsTextComps;
    [SerializeField] TextMeshProUGUI[] _behavioursTextComps;
    [SerializeField] TextMeshProUGUI[] _sensationsTextComps;

    public ArrayList Toggles = new ArrayList();

    private void Start()
    {

        foreach (var cycle in viciousCycle.cycles) //for every toggle that was selected will be saved and brought to the vicious cycle 
        {

            foreach (var item in cycle.Value)
            {
                Debug.Log(item);;
            }

        }

        for (var i = 0; i < _thoughtsTextComps.Length; i += 1) 
        {

            if (viciousCycle.cycles["Thoughts"][i] != null) //checking if the value exists and if so populate it in the thoughtstextComp
            {
                _thoughtsTextComps[i].text = viciousCycle.cycles["Thoughts"][i];

            } else
            {
                _thoughtsTextComps[i].text = ""; //if no value then leave it blank
            }

        }

        for (var i = 0; i < _behavioursTextComps.Length; i += 1)
        {

            if (viciousCycle.cycles["Behaviours"][i] != null) //checking if the value exists and if so populate it in the thoughtstextComp
            {
                _behavioursTextComps[i].text = viciousCycle.cycles["Behaviours"][i];

            }
            else
            {
                _behavioursTextComps[i].text = ""; //if no value then leave it blank
            }

        }

        for (var i = 0; i < _sensationsTextComps.Length; i += 1)
        {

            if (viciousCycle.cycles["Sensations"][i] != null) //checking if the value exists and if so populate it in the thoughtstextComp
            {
                _sensationsTextComps[i].text = viciousCycle.cycles["Sensations"][i];

            }
            else
            {
                _sensationsTextComps[i].text = ""; //if no value then leave it blank
            }

        }

    }
}
