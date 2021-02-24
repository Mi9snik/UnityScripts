using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{    
    public GameObject GOBJ;

    void OnMouseDown()
    {
        Destroy(GOBJ);
    }

}
