using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardReceive : MonoBehaviour
{
    public GameObject[] SpawnPoints;
    int count;

    private void Start()
    {
        count = 0;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<InputEnum>() != null)
        {
            if (count == SpawnPoints.Length) return;
            other.GetComponent<BoxCollider>().enabled = false;
            other.transform.position = SpawnPoints[count].transform.position;
            other.transform.parent = SpawnPoints[count].transform;
            count++;
        }
    }
}
