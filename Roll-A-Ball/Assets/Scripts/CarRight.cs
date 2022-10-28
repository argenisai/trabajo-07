using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRight : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

 
    void Update()
    {

        Vector3 movement = new Vector3(speed, 0.0f, 0.0f);
        Vector3 ex = movement * speed;        
        rb.AddForce(movement * speed);
        
    }
}
