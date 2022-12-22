using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{

    public static PointManager Instance;

    public int points { get; private set; } // Start is called before the first frame update
    [SerializeField] private int scoreToWin;
    [SerializeField] private GameObject exit;
    
    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
            return;
        }

        Instance = this;

    }


    public void incrementPoints()
    {
        points += 1;
        UIManager.Instance.UpdateUi();
        if (points >= scoreToWin)
        {
            exit.gameObject.SetActive(true);
        }

    }
   
}
