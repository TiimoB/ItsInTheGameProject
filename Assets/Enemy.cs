using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private Rigidbody2D rb;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Atan2(transform.position.y - player.transform.position.y, 
                                  transform.position.x - player.transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
        rb.velocity = -transform.right * speed;

    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name.Equals("Player"))
        {
            HealthManager.Instance.takeDamage(10);            Destroy(gameObject);
            Destroy(gameObject);
        }
        else if (collider.GetComponent<BulletScript>() != null)
        {
            PointManager.Instance.incrementPoints();
            Destroy(gameObject);
        }
        

    }
}
