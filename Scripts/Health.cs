using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
   
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "p1")
        {
            GamePlay.p1Life++;

        }

        if (other.tag == "p2")
        {
            GamePlay.p2Life++;

        }
    }
}
