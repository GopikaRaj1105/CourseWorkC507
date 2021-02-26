using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    float xinput;
    float yinput;

    [SerializeField]
    private GameObject p1;
    [SerializeField]
    private GameObject p2;


    float p1angle = 0;
    float p2angle = 0;


    public static int p1Meter = 100;
    public static int p2Meter = 100;

    public static int speed = 15;

    public static bool colourmeterP1 = true;
    public static bool colourmeterP2 = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

  
    void Update()
    {
        xinput = Input.GetAxis("Horizontal");
        yinput = Input.GetAxis("Vertical");

        //movemet for p1
        if(Input.GetKey("w") || Input.GetKey("s"))
        {
            p1.transform.Translate(Vector3.forward * yinput * Time.deltaTime * speed);
        }
        if(Input.GetKey("a") || Input.GetKey("d"))
        {
            p1angle += xinput * 1.5f;
            p1.transform.eulerAngles = new Vector3(0.0f, p1angle, 0.0f);
        }
                                                                                                                                     // cars cant jup so probably use steeps and slopes
        //movement for p2
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            p2.transform.Translate(Vector3.forward * -(yinput) * Time.deltaTime * speed);
        }

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            p2angle += xinput * 1.5f;
            p2.transform.eulerAngles = new Vector3(0.0f, p2angle, 0.0f);

        }

             
    }

    
}
