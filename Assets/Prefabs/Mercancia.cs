using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercancia : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "player")
        {
            Destroy(gameObject);
        }
    }
}
