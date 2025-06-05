using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercancia : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;
    void start ()
    {
        moneyManager = FindObjectOfType<moneyManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "player")
        {
            moneyManager.UpdateMoney(cost);
            Destroy(gameObject);
        }
    }
}