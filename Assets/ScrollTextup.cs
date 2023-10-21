using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollTextup : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(new Vector3(0, .35f,.025f));
        if(transform.position.y > 600)
        {
            SceneManager.LoadScene(1);
        }
    }
}
