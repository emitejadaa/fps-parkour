using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoScript : MonoBehaviour
{
    public int daño;
    HealthManager healthManager;

    private void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            healthManager.UpdateHealth(daño);
            Destroy(gameObject);
        }
    }
}
