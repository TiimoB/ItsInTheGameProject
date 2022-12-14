
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance { get; private set; }
    public int health { get; private set; } = 100; 
    public int maxHealth { get; private set; } = 100;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
            return;
        }

        Instance = this;
    }

    public void takeDamage(int damage)
    {
        health -= damage;
        UIManager.Instance.UpdateUi();
        if (health  <= 0)
        {
            Time.timeScale = 0;
            UIManager.Instance.GameOver();
        }
        
    }

    
}
