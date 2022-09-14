using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanSampah : MonoBehaviour
{
    float jeda = 1.2f;
    float timer;
    public GameObject[] objekSampah;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > jeda)
        {
            int index = Random.Range(0,objekSampah.Length);
            Instantiate(objekSampah[index], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
