using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private GameObject[] powerup = new GameObject[2];

    
    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        yield return new WaitForSeconds(5.0f);
        float pos_x = Random.Range(-19.0f, 76.0f);
        float pos_z = Random.Range(24.0f, 86.0f);
        GameObject temp = powerup[Random.Range(0, 2) % 2];
        Instantiate(temp, new Vector3(pos_x, 2.99f, pos_z), Quaternion.identity);
        StartCoroutine(spawn());

    }
}
