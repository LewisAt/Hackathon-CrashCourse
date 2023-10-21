using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonboys : MonoBehaviour
{
    public checkAnswer check;
    public AudioClip winGameDialog;
    public AudioClip panic;
    public AudioSource mic;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hands")
        { 
            if(check.CheckForCorrectInput() == true)
            {
                GameWin();
            }
            else
            {
                check.RemoveBlocks();
            }
        }
    }
    public void GameWin()
    {

    }
}
