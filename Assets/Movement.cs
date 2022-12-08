using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private int speed;
    [SerializeField] private Rigidbody rb;
    
    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = Vector2.zero;
        if (Input.GetKey(KeyCode.W ))
        {
            velocity.y += speed ;
        } if (Input.GetKey(KeyCode.S ))
        {
            velocity.y -= speed;
        } if (Input.GetKey(KeyCode.A ))
        {
            velocity.x -= speed;
        } if (Input.GetKey(KeyCode.D ))
        {
            velocity.x += speed;
        }

        rb.velocity = velocity;

    }

  
}






