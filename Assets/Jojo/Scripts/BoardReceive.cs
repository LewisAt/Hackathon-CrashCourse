using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardReceive : MonoBehaviour
{
    public GameObject[] SpawnPoints;
    public int count;

    private void Start()
    {
        count = 0;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<InputEnum>() != null)
        {
            if (count == SpawnPoints.Length) return;
            if (SpawnPoints[count].transform.childCount >= 0)
            {
                other.transform.parent = SpawnPoints[count].transform;
                other.transform.localPosition = Vector3.zero;
                other.GetComponent<BoxCollider>().enabled = false;
                other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                count++;
            }
        }
    }
}
