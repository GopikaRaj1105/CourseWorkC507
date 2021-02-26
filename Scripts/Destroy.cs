using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    
    private void OnTriggerEnter()
    {
        Destroy(this.gameObject);
    }

    void Start()
    {
        StartCoroutine(Kill());
    }

    IEnumerator Kill()
    {
        yield return new WaitForSeconds(10.0f);
        Destroy(this.gameObject);
    }
}
