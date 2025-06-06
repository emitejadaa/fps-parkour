using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManager : MonoBehaviour
{
    public UiManager uiManager;
    public float playerMoney;
    public bool UpdateMoney(float amount)
    {
        if (playerMoney - amount < 0)
        {
            Debug.Log("no alcanza");
            return false;
        }
        else
        {
            playerMoney -= amount;
            uiManager.updateMoney();
            return true;
        }

    }
}
