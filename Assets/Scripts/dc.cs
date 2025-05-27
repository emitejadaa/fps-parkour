using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dc : MonoBehaviour
{
   void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto con "+collision.gameObject.name);
        Destroy(gameObject);
    }
}
