using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateMoney (float moneyToAdd)
    {
        if(money + moneyToAdd <0){
            Debug.log ("plata insuficiente");
            return;
        }
        money+= moneyToAdd;
    }
}
