using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public UiManager uiManager;
    public float playerHealth;
    public void UpdateHealth(float amount)
    {
        playerHealth -= amount;
        uiManager.updateHealth();
        if (playerHealth <= 0)
        {
            Debug.Log("moriste");
            SceneManager.LoadScene("fps parkour");
        }
        

    }
}
