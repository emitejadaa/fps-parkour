using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UiManager : MonoBehaviour
{
    public DineroManager dineroManager;
    public HealthManager healthManager;
    public TMP_Text healthText;
    public TMP_Text moneyText;

    public void updateMoney()
    {
        moneyText.text= ": " + dineroManager.playerMoney;
    }
    public void updateHealth()
    {
        healthText.text = ": " + healthManager.playerHealth;

    }
}
