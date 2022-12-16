using System;
using Unity.VisualScripting;
using UnityEngine;


public class Shield : MonoBehaviour
{
    [SerializeField] private float _timeInvincible;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<InputManager>() != null)
        {
            HealthManager.Instance.setInvincible(_timeInvincible);
        }
    }
}