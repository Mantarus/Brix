using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject carriagePrefab;
    public Text scoreText;

    public int lives = 3;

    private int _score = 0;
    private int _scoreMultiplier = 1;

    private void Start()
    {
        scoreText.text = "SCORE: 0";
    }

    public void UpdateScore()
    {
        _score += _scoreMultiplier;
        scoreText.text = $"SCORE: {_score}";
    }

    public void UpdateAfterLose()
    {
        lives--;
        if (lives <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0;
    }

}
