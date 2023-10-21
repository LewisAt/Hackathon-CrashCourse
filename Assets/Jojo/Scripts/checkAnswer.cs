using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkAnswer : MonoBehaviour
{
    public List<InputEnum> checkInput;
    public List<InputEnum> Answer;
    GameObject[] InputCount;
    public GameObject PooPosition;

    private void Start()
    {
        InputCount = GetComponent<BoardReceive>().SpawnPoints;
    }
    public void OnTriggerEnter(Collider other)
    {


        
        if (other.GetComponent<InputEnum>() != null)
        {
            checkInput.Add(other.gameObject.GetComponent<InputEnum>());
            //print(checkInput.Count);
        }
        if (checkInput.Count == Answer.Count)
        {

            CheckForCorrectInput();
            return;
        }

    }
    void CheckForCorrectInput()
    {

        for(int i = 0; i < Answer.Count; i++)
        {
            Debug.Log(checkInput[i] +"  " +  Answer[i]);

            if (checkInput[i] != Answer[i])
            {
                return;
            }
            StartCoroutine(poo());
        }
        Debug.Log("CorrectAnswerWasfound");
    }
    IEnumerator poo()
    {
        int numberOfInterations = checkInput.Count;
        for (int i = 0; i < numberOfInterations; i++)
        {
            checkInput[0].transform.position = PooPosition.transform.position;
            checkInput[0].GetComponent<BoxCollider>().enabled = true;
            Rigidbody rb = checkInput[0].GetComponent<Rigidbody>();
            rb.constraints = ~RigidbodyConstraints.FreezePositionY;
            checkInput.RemoveAt(0);
            yield return new WaitForSeconds(0.2f);
        }

    }



}
