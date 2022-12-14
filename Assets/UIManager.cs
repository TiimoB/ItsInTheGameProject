using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI points;
    [SerializeField] private Image healthBar;
    [SerializeField] private Gradient healthbarGradient;
    [SerializeField] private GameObject gameOverScreen;
    
    public static UIManager Instance { get; private set; }
    private void Awake()
    {
        healthBar.color = healthbarGradient.Evaluate(0);

        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
            return;
        }

        Instance = this;
    }

    public void UpdateUi()
    {
        float progress = HealthManager.Instance.health / (float)HealthManager.Instance.maxHealth;
        healthBar.fillAmount = progress;
        healthBar.color = healthbarGradient.Evaluate(1 - progress);
        
        String score = "Points: " + PointManager.Instance.points;
        points.text = score;
    }

    public void Retry()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name); 
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
