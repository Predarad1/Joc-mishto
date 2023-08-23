using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gol : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 5f;
    private bool up =true;
    private float initial_position;
    void Start()
    {
        initial_position = transform.position.y;
    }

    void Update()
    {
        if (up)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.y>=initial_position + distance)
            {
                up = false;
            }
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            if (transform.position.y <= initial_position - distance)
            {
                up = true;
            }
        }
    }
}
