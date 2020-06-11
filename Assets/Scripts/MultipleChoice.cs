using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MultipleChoice : MonoBehaviour
{
    [SerializeField] ViciousCycleReference viciousCycle; // calls the ViciousCyclereference script
    [SerializeField] string bucket;

    [SerializeField] Toggle[] toggle;   // toggles go in here
    [SerializeField] GameObject Continue; // continue button goes here
    public List<string> Toggles = new List<string>(); // this is the ArrayList that will be used to count how many toggles are on
        
    public int maxAmount; // minimum number of toggles needed to activate button
    public int minAmount; // maximum number of toggles needed before button goes away

    public void Awake() // start the slide off with the button disabled
    {
        Continue.SetActive(false);
    }
    public void CountToggles() // this counts if we are meeting our requirements for the toggle
    {

        Toggles = PullSelectedToggles(); // this pulls from the ArrayList to count
        //Debug.Log(Toggles.Count);

        viciousCycle.cycles[bucket] = Toggles;

        if (Toggles.Count < minAmount) // if Toggle count meets minimum amount then the button is on, if it's below it turns off
        {
            Continue.SetActive(false);
        } else
        {
            Continue.SetActive(true);
        }

        if (Toggles.Count > maxAmount) // if Toggle count exceeds maximum amount then the button turns off
        {
            Continue.SetActive(false);
        }

    }

    private List<string> PullSelectedToggles() // This is the ArrayList that feeds into Toggles so we can count how many toggles are on.
    {
        var results = new List<string>();

        foreach (var item in toggle)
        {

            if (item.isOn) results.Add(item.gameObject.GetComponentInChildren<TextMeshProUGUI>().text);
        }

        return results;
    }

}
