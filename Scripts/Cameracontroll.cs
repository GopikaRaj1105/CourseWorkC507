using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroll : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    public float cubeX;
    public float cubeY;
    public float cubeZ;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        cubeX = player.transform.eulerAngles.x;
        cubeY = player.transform.eulerAngles.y;
        cubeZ = player.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(cubeX + 90, cubeY, cubeZ + 90);

    }
}
