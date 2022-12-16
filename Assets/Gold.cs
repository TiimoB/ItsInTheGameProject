using System;
using UnityEngine;

    public class Gold : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.GetComponent<InputManager>() != null)
            {
                GunManager.Instance.IncrementGun();
            }
        }
    }
