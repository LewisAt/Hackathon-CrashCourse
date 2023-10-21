using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardReceive : MonoBehaviour
{
    public GameObject[] SpawnPoints;
    private checkAnswer AnswerCheckScript;
    public int count;

    private void Start()
    {
        AnswerCheckScript = GetComponent<checkAnswer>();
        count = 0;
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<InputEnum>() != null)
        {
            Debug.Log(SpawnPoints[count].transform.childCount);
            Debug.Log(count);

            if (SpawnPoints[count].transform.childCount > 0)
            {
                Debug.Log(" I am full");
                return;
            }
            else
            {
                print(other.GetComponent<InputEnum>().input + " joined");
                other.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                other.transform.parent = SpawnPoints[count].transform;
                other.transform.localPosition = Vector3.zero;
                other.GetComponent<BoxCollider>().enabled = false;
                other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                AnswerCheckScript.addThingy(other);
                count++;
            }
            
        }
        /*if (other.GetComponent<InputEnum>() != null)
        {
            if (count == SpawnPoints.Length) return;

            if (SpawnPoints[count].transform.childCount >= 0)
            {

                print(other.GetComponent<InputEnum>().input + " joined");
                other.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                other.transform.parent = SpawnPoints[count].transform;
                other.transform.localPosition = Vector3.zero;
                other.GetComponent<BoxCollider>().enabled = false;
                other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                AnswerCheckScript.addThingy(other);
                
                
            }
        }*/
    }
}
