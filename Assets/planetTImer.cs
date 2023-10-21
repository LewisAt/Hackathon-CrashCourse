using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class planetTImer : MonoBehaviour
{
    public float timer = 300.0f;
    float CurrentTime;
    public GameObject endPosition;
    public GameObject Planet;
    Vector3 StartPosition;
    public Slider slider;
    private void Start()
    {
        StartPosition = Planet.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;
        float Fill = CurrentTime / timer;
        slider.value = Fill;

        Planet.transform.position = Vector3.Lerp(StartPosition, new Vector3(endPosition.transform.position.x - 500, 0, 0), Fill);
        if(timer <=0)
        {
            SceneManager.LoadScene(3);
            //end game load end scene
        }
    }
}
