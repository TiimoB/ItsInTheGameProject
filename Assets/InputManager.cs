using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.HID;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private int speed;

    [SerializeField] private Rigidbody2D rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 velocity = Vector2.zero;
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
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

        rb.velocity = new Vector3(velocity.x, velocity.y, 0);

        float angle = GetAngleTo(mousepos);
        // Debug.Log(angle);
        
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        

    }

    float GetAngleTo(Vector3 target)
    {
        Vector3 pos = rb.position;
        double a = pos.x - target.x;
        double b = pos.y - target.y;
        
        return (float) Math.Atan2(b, a) * Mathf.Rad2Deg;

    }
  
}






