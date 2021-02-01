using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
     void OnTriggerEnter (Collider other)
     {if(other.gameObject.tag == "player")
     {Application.LoadLevel ("Exit");}}   

}