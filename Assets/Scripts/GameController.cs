using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject carriagePrefab;
    public List<GameObject> bricks;
    
    public int lives = 3;

    private int _score = 0;
    private int _scoreMultiplier = 1;

    private Text _scoreText;

    public void UpdateScore()
    {
        _score += _scoreMultiplier;
    }

    public void UpdateAfterLose()
    {
        lives--;
        if (lives <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
    }

}
