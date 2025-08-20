using System;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Debug = UnityEngine.Debug;

public class interactions : MonoBehaviour
{
    private bool key1 = false;
    private bool key2 = false;

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
    {   switch (other.tag)
        {
     [SerializeField] private bool key1 = false;
    [SerializeField] private bool key2 = false;
    [SerializeField] private GameObject door;
    private Animator animatordoor;
    
    private void start()
}
      
        {
            case "npc1":
                Debug.Log("Obtuve la llave 1.");
                key1 = true;
                break;
            case "NPC2":
                Debug.Log("Obtuve la llave 2.");
                key2 = true;
                break;
                case "Door":
                    Debug.Log("Abrí la puerta");
                    AnimatorDoor.setbool("Anim_Door", true);
                    break;


        }
    }
    
    Ontrigger
}

