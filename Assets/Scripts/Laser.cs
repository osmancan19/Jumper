using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(0, Time.deltaTime * 0.1f , 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Time.deltaTime * 0.1f , 0);
    }
}
