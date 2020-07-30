using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAnim : MonoBehaviour
{
    public Animator animWalk;
    public Animator animMove;

   public void PlayAnim()
    {
        animWalk.SetBool("Play",true);
        animMove.SetBool("Play", true);
        StartCoroutine("Time");
    }

    IEnumerator Time()
    {
        yield return new WaitForSeconds(9f);
        gameObject.SetActive(false);
    }
}
