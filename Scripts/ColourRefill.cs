using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourRefill : MonoBehaviour
{
    // Start is called before the first frame update
    


    private void OnTriggerEnter(Collider player)
    {
       if(player.tag == "p1")
        {
            playermovement.p1Meter = 100;
            playermovement.colourmeterP1 = true;
           
        }
    }
}
