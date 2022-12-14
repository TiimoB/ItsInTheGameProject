using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletScript : MonoBehaviour
{
    public int speed;

    public int damage;

    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // forward is in the z axis, we are in 2d so we dont use the z axis. 
        // right would move us backwards, so negative right moves us forward!
        // unity's forward / right / up system is kind of weird in 2d,
        // but this is the magic line that moves us forward
        rb.velocity = -transform.right * speed;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    }
}