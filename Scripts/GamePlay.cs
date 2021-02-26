using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{

    public static Dictionary<GameObject, string> cubeColour = new Dictionary<GameObject, string>();

    [SerializeField]
    private GameObject p1;
    [SerializeField]
    private GameObject p2;

    public static int p1Life = 3;
    public static int p2Life = 3;

   
    

    // Start is called before the first frame update
    void Start()
    {
       
        for (int i = 0; i < 96; i++)
        {
            GameObject temp = GameObject.Find("colourcubes").transform.Find("Cube" + i).gameObject;
            cubeColour.Add(temp, "none");
        }
       
    }
   
    void Update()
    {
       
        if(p1Life == 0 || p2Life == 0)
        {
            p1Life = 3;
            p2Life = 3;
            Timer.timeremaining = 100;
            SceneManager.LoadScene("GameOver");
        }

        if(p1.transform.position.y < -7.0f)
        {
            p1.transform.position = new Vector3(-31.35f, 2.63f, -34.4f);
            p1.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
            p1Life--;
           
        }


        if (p2.transform.position.y < -5.0f)
        {
            p2.transform.position = new Vector3(85.69f, 2.2f, 116.6f);
            p2.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
            p2Life--;
            
        }

        if (Input.GetKey(KeyCode.R))
        {
            p1.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        }
        
        if (Input.GetKey(KeyCode.Keypad5))
        {
            p2.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        }

      
        
    }
}
