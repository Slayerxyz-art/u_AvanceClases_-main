using System;
using UnityEngine;

public class interactions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("este es el start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("este es el update");
        Application.targetFrameRate = 60;
}

    private void FixedUpdate()
    {
        Debug.Log("este es el fixed");
    }
}
