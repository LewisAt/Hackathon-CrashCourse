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
        if (other.GetComponent<InputEnum>() != null)
        {
            if (checkInput.Count != Answer.Count)
            {
                checkInput.Add(other.gameObject.GetComponent<InputEnum>());
            }
            if (checkInput.Count == Answer.Count)
            {
                CheckForCorrectInput();
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
        StartCoroutine(poo());
    }
    IEnumerator poo()
    {
        yield return new WaitForSeconds(3f);
        int numberOfInterations = checkInput.Count;
        for (int i = 0; i < numberOfInterations; i++)
        {
            InputCount[i].transform.DetachChildren();
            checkInput[0].transform.position = PooPosition.transform.position;
            checkInput[0].GetComponent<BoxCollider>().enabled = true;
            Rigidbody rb = checkInput[0].GetComponent<Rigidbody>();
            rb.constraints = ~RigidbodyConstraints.FreezeAll;
            rb.AddForce(Vector3.down * 3);
            checkInput.RemoveAt(0);
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(3f);
        boardReceive.count = 0;
    }
}
