using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        //Destroy ball when in contact with other i.e. dog 
        Destroy(gameObject);
    }
}
