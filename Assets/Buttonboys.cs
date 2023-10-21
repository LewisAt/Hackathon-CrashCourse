using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonboys : MonoBehaviour
{
    public checkAnswer check;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hands")
        { 
            if(check.CheckForCorrectInput() == true)
            {
                Debug.Log("you won ");
                //GameWin();
            }
            else
            {
                check.RemoveBlocks();
            }
        }
    }
}
