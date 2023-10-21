using MixedReality.Toolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMove : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 2.5f;
    public Camera cam;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(hor,0, ver);
        Vector3 newDirection = cam.transform.TransformDirection(direction);
        Vector3 lastDirection = new Vector3(newDirection.x,0, newDirection.z);

        rb.velocity = lastDirection.normalized * speed; 
    }
}
