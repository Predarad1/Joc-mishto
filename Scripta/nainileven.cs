using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nainileven : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,25,0)*Time.deltaTime);

        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 inclinate = new Vector3(verticalInput, 0 ,horizontalInput);

        transform.Rotate(inclinate);
    }
}
