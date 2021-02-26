using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalc : MonoBehaviour
{
    public GameObject Winner;
    void Start()
    {
        Debug.Log(Timer.g_count);
        Debug.Log(Timer.b_count);
        if (GamePlay.p1Life == 0)
        {
            Winner.GetComponent<Text>().text = "Player2 wins";
        }
        else if (GamePlay.p2Life == 0)
        {
            Winner.GetComponent<Text>().text = "Player1 wins";
        }

        else
        {
            if (Timer.g_count > Timer.b_count)
            {
                Winner.GetComponent<Text>().text = "Player1 wins";
            }

            else if (Timer.g_count < Timer.b_count)
            {
                Winner.GetComponent<Text>().text = "Player2 wins";
            }

            else 
            {
                Winner.GetComponent<Text>().text = "Draw-Game!";
            }
        }


    }


}
