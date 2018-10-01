using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    
    public Text pontos;
    public static GameManager Instance;

    public int score = 0;

    #region Singleton
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }
    #endregion

    public void AddPoints(int value)
    {
        score += value;
        pontos.text = score.ToString();
    }
}
