using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))

        {
            Application.Quit();
            Debug.Log("Quit");

                }
    }
}
