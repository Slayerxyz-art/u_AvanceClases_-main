using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class interactions : MonoBehaviour
{
    private bool key1 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC1"))
        {
            Debug.Log("chocó el Player conmigo");
            key1 = true;
}


