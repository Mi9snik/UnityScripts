using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float MoveSpeed = 5.0f;
    public float SprintSpeed = 10.0f;

    string W = KeyCode.W;
    string S = KeyCode.S;
    string A = KeyCode.A;
    string D = KeyCode.D;

        void Update() {
            Rigidbody rigidbody = GetComponent<Rigidbody>();

            if(Input.GetKey(W)) {
                transform.position += Vector3.forward * Time.deltaTime * MoveSpeed;
                if(Input.GetKey("shift")) {
                    MoveSpeed == SprintSpeed;
                }
            }
            else if(Input.GetKey(S)) {
                rigidbody.position += Vector3.back * Time.deltaTime * MoveSpeed;
                if(Input.GetKey("shift")) {
                    MoveSpeed == SprintSpeed;
                }
            }
            else if(Input.GetKey(A)) {
                rigidbody.position += Vector3.left * Time.deltaTime * MoveSpeed;
                if(Input.GetKey("shift")) {
                    MoveSpeed == SprintSpeed;
                }
            }
            else if(Input.GetKey(D)) {
                rigidbody.position += Vector3.right * Time.deltaTime * MoveSpeed;
                if(Input.GetKey("shift")) {
                    MoveSpeed == SprintSpeed;  
                }
            }      
        }
    }
}
