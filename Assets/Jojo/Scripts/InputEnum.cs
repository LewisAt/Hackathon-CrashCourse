using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEnum : MonoBehaviour
{
    public enum ListOfInputs
    {
        If,
        equals
    }
    public ListOfInputs input;
    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * 4);
    }
}
