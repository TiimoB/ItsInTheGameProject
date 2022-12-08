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
    void FixedUpdate()
    {
        Vector2 velocity = Vector2.zero;
        // note: 1.6 isnt *exactly* right. but, its close enough to the point that it might as well be!
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            velocity.x -= (int) (speed / 1.6);
            velocity.y += (int) (speed / 1.6);
        }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            velocity.x += (int) (speed / 1.6);
            velocity.y += (int) (speed / 1.6);
        }else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            velocity.x -= (int) (speed / 1.6);
            velocity.y -= (int) (speed / 1.6);
        }else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            velocity.x += (int) (speed / 1.6);
            velocity.y -= (int) (speed / 1.6);
        }else if (Input.GetKey(KeyCode.W ))
        {
            velocity.y += speed ;
        } else if (Input.GetKey(KeyCode.S ))
        {
            velocity.y -= speed;
        } else if (Input.GetKey(KeyCode.A ))
        {
            velocity.x -= speed;
        } else if (Input.GetKey(KeyCode.D ))
        {
            velocity.x += speed;
        }

        rb.velocity = velocity;

    }

  
}






