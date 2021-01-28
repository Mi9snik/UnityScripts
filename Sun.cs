using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Sun : MonoBehaviour
{
    // first try of night and day selection script.
    public float speed;

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, speed * Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }
}
