using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardCheck : MonoBehaviour
{
    Vector3 input;
    public GameObject[] SpawnPoints;
    public GameObject test;
    int count;

    private void Start()
    {
        count = 0;
        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            if (SpawnPoints[i].transform.childCount == 0)
            {

            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<InputEnum>() != null)
        {
            if (count == SpawnPoints.Length) return;
            other.transform.position = SpawnPoints[count].transform.position;
            count++;
        }
    }
}
