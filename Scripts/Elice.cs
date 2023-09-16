using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,2000,0)*Time.deltaTime);
    }
}
