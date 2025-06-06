using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio;
    DineroManager dineroManager;

    private void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if (dineroManager.UpdateMoney(precio))
            {
                Destroy(gameObject);
            }
            
        }
    }
}
