﻿ using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
 
 public class Darkness : MonoBehaviour
 {
 
     public List<Light> Lights;
 
     void OnPreCull()
     {
         foreach (Light light in Lights)
         {
             light.enabled = false;
         }
     }
 
     void OnPostRender()
     {
         foreach (Light light in Lights)
         {
             light.enabled = true;
         }
     }
 }