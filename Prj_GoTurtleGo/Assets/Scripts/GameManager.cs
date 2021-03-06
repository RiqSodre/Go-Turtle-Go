﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    
    public Text energyText;
    public static GameManager Instance;

    public int energy = 0;
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

    public void Eat(int value)
    {
        energy += value;

        AddPoints(value * 10);
    }

    public void AddPoints(int value)
    {
        score += value;
    }
}
