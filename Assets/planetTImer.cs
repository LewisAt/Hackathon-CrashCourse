using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetTImer : MonoBehaviour
{
    public float timer = 300.0f;
    float CurrentTime;
    public GameObject endPosition;
    public GameObject Planet;
    public Vector3 StartPosition;

    private void Start()
    {
        StartPosition = Planet.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;

        Planet.transform.position = Vector3.Lerp(StartPosition, new Vector3(endPosition.transform.position.x - 500, 0, 0),CurrentTime/timer);
        if(timer <=0)
        {
            //end game load end scene
        }
    }
}
