using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomMove : MonoBehaviour
{
    private Rigidbody rb;
    Camera cam;
    private void Awake()
    {
        Camera cam = Camera.main;
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(hor,0, ver);
        rb.velocity = direction;
    }
}
