using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RocketScript : MonoBehaviour
{
    float turningspeed = 100;
    float thrustvalue = 10;
    float gravity = 2;
    Rigidbody rb;
    Vector3 velocity, acceleration;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ///acceleration = Vector3.zero;
        ///acceleration += gravity * Vector3.down;

        if (Input.GetKey(KeyCode.W))
        {
            // transform.position += transform.up * Time.deltaTime;
            ///acceleration += thrustvalue * transform.up;
        } rb.AddForce(thrustvalue * transform.up);

        if (Input.GetKey(KeyCode.A))
        //if "A" is pressed Roll left
        {
            transform.Rotate(Vector3.up, turningspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        //if "up arrow" is pressed Pitch Up
        {
            transform.Rotate(Vector3.right, turningspeed * Time.deltaTime);
        }

        ///role using mouse
        transform.Rotate(Vector3.right, Input.GetAxis("Horizontal")  * turningspeed * Time.deltaTime);

        // velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }


    private void OnCollisionEnter(Collision collision)
    {
        
    }



}







