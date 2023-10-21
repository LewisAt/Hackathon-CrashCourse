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

            check.RemoveBlocks();    
        }
    }
}
