using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardCheck : MonoBehaviour
{
    public Vector3 middlePoint;
    Vector3 input;
    public GameObject[] inputSlots; 

    private void Start()
    {
        middlePoint = GetComponent<Transform>().localPosition;
    }

    public void OnTriggerEnter(Collider other)
    {
        print("colliding is working");
        if (other.GetComponent<InputEnum>() != null)
        {
            
        }
    }
}
