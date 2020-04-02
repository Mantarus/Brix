using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject carriagePrefab;
    public Text scoreText;
    public Text scoreMultiplierText;
    public Text livesLeftText;
    public Text bricksLeftText;

    public int lives = 3;
    public int maxScoreMultiplier = 5;
    
    private int _score = 0;
    private int _scoreMultiplier = 1;
    private int _livesLeft;
    private int _brickCount = 0;

    private void Start()
    {
        _livesLeft = lives;
        scoreText.text = $"SCORE: {_score}";
        scoreMultiplierText.text = $"x{_scoreMultiplier}";
        livesLeftText.text = $"LIVES: {_livesLeft}";
    }

    public void UpdateScore()
    {
        _score += _scoreMultiplier;
        scoreText.text = $"SCORE: {_score}";
    }

    public void UpdateAfterLose()
    {
        _livesLeft--;
        livesLeftText.text = $"LIVES: {_livesLeft}";
        _scoreMultiplier = 1;
        scoreMultiplierText.text = $"x{_scoreMultiplier}";
        
        if (_livesLeft <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0;
    }

    public void IncreaseScoreMultiplier()
    {
        _scoreMultiplier = Mathf.Min(_scoreMultiplier + 1, maxScoreMultiplier);
        scoreMultiplierText.text = $"x{_scoreMultiplier}";
    }
    
    public void DecreaseScoreMultiplier()
    {
        _scoreMultiplier = Mathf.Max(_scoreMultiplier - 1, 1);
        scoreMultiplierText.text = $"x{_scoreMultiplier}";
    }

    public void IncreaseBrickCount()
    {
        _brickCount++;
        bricksLeftText.text = $"LEFT: {_brickCount}";
    }

    public void DecreaseBrickCount()
    {
        _brickCount--;
        bricksLeftText.text = $"LEFT: {_brickCount}";
        
        if (_brickCount <= 0)
        {
            GameOver();
        }
    }

}
