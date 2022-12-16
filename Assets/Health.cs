using System;
using UnityEngine;


    public class Health : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.GetComponent<InputManager>() != null)
            {
                HealthManager.Instance.Heal(10);
            }
        }
    }
