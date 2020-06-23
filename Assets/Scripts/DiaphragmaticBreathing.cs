using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaphragmaticBreathing : MonoBehaviour
{

    public Animator[] Breathing;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayAnim()
    {
        for (var i = 0; i < Breathing.Length; i += 1)
        {
            Breathing[i].SetBool("Play", true);
            Breathing[i].SetBool("Stop", false);
        }
    }

    public void StopAnim()
    {
          
    }
}
