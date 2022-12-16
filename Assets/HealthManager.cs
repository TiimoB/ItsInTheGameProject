
using System;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance { get; private set; }
    public int health { get; private set; } = 100; 
    public int maxHealth { get; private set; } = 100;

    [SerializeField] private bool _isInvincible = false;
    private float _invincibilityEnd;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
            return;
        }

        Instance = this;
    }

    public void Update()
    {
        if (_isInvincible && Time.time > _invincibilityEnd)
        {
            _isInvincible = false;
        }
    }

    public void Heal(int heal)
    {
        health += heal;
        UIManager.Instance.UpdateUi();
    }

    public void takeDamage(int damage)
    {

        if (_isInvincible)
        {
            return;
        }
        
        health -= damage;
        UIManager.Instance.UpdateUi();
        if (health  <= 0)
        {
            Time.timeScale = 0;
            UIManager.Instance.GameOver();
        }
        
    }

    public void setInvincible(float timeInvincible)
    {
        _isInvincible = true;
        _invincibilityEnd = Time.time + timeInvincible; 
    }

    
}
