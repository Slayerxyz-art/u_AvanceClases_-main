using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
[SerializeField] private bool key1 =
false;
public class NPC1 : MonoBehaviour
{
   private bool key1 = false;

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
         Debug.Log("chocó el player conmigo");
         key1 = true;
      }
   }
   
}

