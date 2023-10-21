using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
                Debug.Log("you won ");
                //GameWin();
                SceneManager.LoadScene(2);
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
