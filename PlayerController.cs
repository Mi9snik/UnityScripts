﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 5.0f;

        void Update()
        {
            Rigidbody rigidbody = GetComponent<Rigidbody>();
    
            if(Input.GetKey(KeyCode.W)) {
                transform.position += Vector3.forward * Time.deltaTime * MoveSpeed;
            }
            else if(Input.GetKey(KeyCode.S)) {
                rigidbody.position += Vector3.back * Time.deltaTime * MoveSpeed;
            }
            else if(Input.GetKey(KeyCode.A)) {
                rigidbody.position += Vector3.left * Time.deltaTime * MoveSpeed;
            }
            else if(Input.GetKey(KeyCode.D)) {
                rigidbody.position += Vector3.right * Time.deltaTime * MoveSpeed;
        }
    }
}
