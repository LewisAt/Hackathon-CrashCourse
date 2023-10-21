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
    public void addtoList(InputEnum inputtedBlock)
    {
        checkInput.Add(inputtedBlock);
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
    public bool CheckForCorrectInput()
    {

        for (int i = 0; i < Answer.Count; i++)
        {
            if (checkInput[i] != Answer[i])
            {
                print("wrong answer in" + i);
                return false;
            }
        }
        return true;
    }

    public void RemoveBlocks()
    {
        StartCoroutine(poo());
    }
    IEnumerator poo()
    {
        yield return new WaitForSeconds(0.5f);
        int numberOfInterations = checkInput.Count;

        for (int i = 0; i < numberOfInterations ; i++)
        {
            Debug.Log("I value is " + i +" "+ numberOfInterations);
            Rigidbody rb = checkInput[i].GetComponent<Rigidbody>();

            checkInput[i].gameObject.transform.parent = null;
            checkInput[i].gameObject.transform.position = PooPosition.transform.position;
            checkInput[i].gameObject.GetComponent<BoxCollider>().enabled = true;
            
            rb.constraints = ~RigidbodyConstraints.FreezeAll;
            rb.AddForce(Vector3.down * 8);
            yield return new WaitForSeconds(0.5f);
        }
        checkInput.Clear();
        boardReceive.count = 0;


        GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(3f);
        GetComponent<BoxCollider>().enabled = true;

    }
}
