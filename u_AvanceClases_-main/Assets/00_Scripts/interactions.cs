using System;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Debug = UnityEngine.Debug;

public class interactions : MonoBehaviour
{
    private bool key1 = false;

    /*
    private void OnTriggerEnter(Collider other)  // al ingresar a un collider
    {
        if (other.CompareTag("npc1")) //si choco con un objeto
        {
            Debug.Log("chocó el player conmigo");
            key1 = true;
            
            if (other.CompareTag("NPC2")) // así obtengo la llave 2
                
                Debug.Log?("conseguí la llave")
            key2 = true;
            
}
    

        {
            if (other.CompareTag("NPC2")) // así obtengo la llave 2
        }  
        {
           Debug.Log?("conseguí la llave")
               key2 = true;
        }
        */
    private void OnTriggerEnter(Collider other)
    {
       Switch (other.tag) 
       {
           case"npc1":
               Debug.Log"Obtuve la llave 1.");
               key1 = true;
               Break;
               case "NPC2");
               
       }
    }

