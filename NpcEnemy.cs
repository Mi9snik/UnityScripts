using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Trigger;
    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterController>()) 
        {
            Enemy.LookAt(Player);
        }
    }

    void Update()
    {
        
    }
}
