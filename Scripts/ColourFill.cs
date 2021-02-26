using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColourFill : MonoBehaviour
{

    void OnTriggerEnter(Collider player)
    {

        if (player.tag == "p1")
        {
            if (playermovement.colourmeterP1)
            {
                // Debug.Log("collided with p1");
                GetComponent<Renderer>().material.color = Color.green;
                if(GamePlay.cubeColour[this.gameObject] != "Green")
                {
                    playermovement.p1Meter -= 5;
                }
                GamePlay.cubeColour[this.gameObject] = "Green";

            }
            if (playermovement.p1Meter == 0)
            {
                playermovement.colourmeterP1 = false;
            }
           
            
        }

    
 

       if (player.tag == "p2")
        {
            if (playermovement.colourmeterP2)
            {
                //Debug.Log("collided with p2");
                
                GetComponent<Renderer>().material.color = Color.blue;
                if (GamePlay.cubeColour[this.gameObject] != "Blue")
                {
                    playermovement.p2Meter -= 5;
                    
                }
                GamePlay.cubeColour[this.gameObject] = "Blue";
            }
            if (playermovement.p2Meter == 0)
            {
                playermovement.colourmeterP2 = false;
            }

        }

    }
}
