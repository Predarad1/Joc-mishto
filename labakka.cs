using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labakka : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(100,10,0)*Time.deltaTime);
        //transform.Translate(new Vector3(0,10,0)*Time.deltaTime);
    }
}