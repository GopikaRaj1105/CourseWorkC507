using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourRefillP2 : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider player)
    {
        if (player.tag == "p2")
        {
            playermovement.p2Meter = 100;
            playermovement.colourmeterP2 = true;
           
        }
    }
}
