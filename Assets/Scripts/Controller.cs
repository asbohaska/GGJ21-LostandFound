﻿using UnityEngine;
 using System.Collections;
 
 public class Controller : MonoBehaviour {
     //Variables
     public float speed = 6.0F;
     public float jumpSpeed = 8.0F; 
     public float gravity = 20.0F;
     private Vector3 moveDirection = Vector3.zero;
     private Vector3 rotateDirection = Vector3.zero;
 public float rotatespeed = 2f;
     void Update() {
         CharacterController controller = GetComponent<CharacterController>();
         // is the controller on the ground?
         if (controller.isGrounded) {
             //Feed moveDirection with input.
             moveDirection = new Vector3(0,0, Input.GetAxis("Vertical"));
             moveDirection = transform.TransformDirection(moveDirection);
             transform.Rotate(0f, Input.GetAxis("Horizontal")*rotatespeed,0f);
             //Multiply it by speed.
             moveDirection *= speed;
             rotateDirection *= rotatespeed;
             //Jumping
             if (Input.GetButton("Jump"))
                 moveDirection.y = jumpSpeed;
             
         }
         //Applying gravity to the controller
         moveDirection.y -= gravity * Time.deltaTime;
         //Making the character move
         controller.Move(moveDirection * Time.deltaTime);
     }
 }