using MixedReality.Toolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkAnswer : MonoBehaviour
{
    public List<InputEnum> checkInput;
    public List<InputEnum> Answer;
    GameObject[] InputCount;
    public GameObject PooPosition;
    BoardReceive boardReceive;

    private void Start()
    {
        InputCount = GetComponent<BoardReceive>().SpawnPoints;
        boardReceive = GetComponent<BoardReceive>();
    }
    public void OnTriggerEnter(Collider other)
    {
        
        
    }
    public void addThingy(Collider other)
    {
        if (other.GetComponent<InputEnum>() != null)
        {
            for (int i = 0; i < InputCount.Length; i++)
            {
                if (InputCount[i].transform.childCount == 0)
                {
                }
                else
                {
                    Debug.Log("Dogs are here");
                }
            }
            //print(checkInput.Count);
        }
        
    }
    void CheckForCorrectInput()
    {

        for (int i = 0; i < Answer.Count; i++)
        {
            if (checkInput[i] != Answer[i])
            {
                print("wrong answer in" + i);
                continue;
            }
        }
    }

    public void RemoveBlocks()
    {
        StartCoroutine(poo());
    }
    IEnumerator poo()
    {
        yield return new WaitForSeconds(3f);
        int numberOfInterations = checkInput.Count;
        for (int i = 0; i < numberOfInterations; i++)
        {
            checkInput[0].GetComponent<BoxCollider>().enabled = false;
            Rigidbody rb = checkInput[0].GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezeAll;

            checkInput[0].transform.parent = null;
            checkInput[0].transform.position = PooPosition.transform.position;
            checkInput[0].GetComponent<BoxCollider>().enabled = true;
            
            rb.constraints = ~RigidbodyConstraints.FreezeAll;
            rb.AddForce(Vector3.down * 8);


            checkInput.RemoveAt(0);

            yield return new WaitForSeconds(0.5f);
        }
        GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(3f);
        GetComponent<BoxCollider>().enabled = true;

    }
}
