﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void UpdateMoneyTxt (string moneyAmount)
    {
        txtMoney.text = moneyAmount;
    }
}
