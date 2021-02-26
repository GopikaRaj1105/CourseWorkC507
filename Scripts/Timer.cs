using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

  

    public static int timeremaining = 100;
    public static int g_count;
    public static int b_count;
    // Start is called before the first frame update
    void Start()
    {
       

        StartCoroutine(countdown());
    }

    IEnumerator countdown()
    {
        yield return new WaitForSeconds(1.0f);
        timeremaining--;
        
        StartCoroutine(countdown());
    }

    // Update is called once per frame
    void Update()
    {
        if(timeremaining <= 0)
        {
            for (int i = 0; i < 96; i++)
            {
                GameObject temp = GameObject.Find("colourcubes").transform.Find("Cube" + i).gameObject;
                string colour = GamePlay.cubeColour[temp];
                if (colour == "Green")
                {
                    g_count++;
                }
                if (colour == "Blue")
                {
                    b_count++;
                }
            }
            GamePlay.p1Life = 3;
            GamePlay.p2Life = 3;
            Timer.timeremaining = 100;
            SceneManager.LoadScene("GameOver");
        }
    }
}
