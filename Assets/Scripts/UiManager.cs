using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UiManager : MonoBehaviour
{
    public DineroManager dineroManager;
    public TMP_Text text;

    public void updateMoney()
    {
        text.text = ": " + dineroManager.playerMoney;
    }
}
